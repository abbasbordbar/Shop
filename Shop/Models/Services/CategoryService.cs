using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class CategoryService : ICategoryService
    {
        DBShop dB;
        public CategoryService(DBShop dBShop)
        {
            dB = dBShop;

        }

        public Category GetCategoryByName(string CatName)
        {
            return dB.categories.Where(c => c.CatName == CatName).SingleOrDefault();
        }

        public List<Category> GetSubCategoryById(int CategoryId)
        {
            List<Category> categories = (from c in dB.categories
                                         join s in dB.subCategories on c.CategoryId equals s.SubId
                                         where s.ParentId == CategoryId
                                         select c).ToList();

            return categories;
        }

        public CategoryViewModel GetSubCategoryByName(string CategoryName)
        {
            Category category = GetCategoryByName(CategoryName);
            if (category == null)
                return null;
            CategoryViewModel categoryViewModel = new CategoryViewModel
            {
                CatName = category.CatName,
                Categories = GetSubCategoryById(category.CategoryId)
            };
            return categoryViewModel;
        }
        public List<Category> CategoryForAdmin()
        {
            return dB.categories.ToList();
        }

        public bool DeleteCategory(Category category)
        {
            dB.Update(category);
            int res = dB.SaveChanges();
            if (res > 0)
                return true;
            return false;

        }

        public Category FindCategoryById(int id)
        {
            return dB.Find<Category>(id);

        }

        public List<GetCategoryForAddViewModel> GetCategoryForAdd()
        {
            return dB.categories.Select(c => new GetCategoryForAddViewModel { Id = c.CategoryId, Title = c.CatName }).ToList();

        }
        public bool AddCategory(Category category, List<int> ParentList)
        {
            dB.Add(category);
            int res = dB.SaveChanges();
            if (res > 0)
            {
                if (ParentList != null)
                {
                    AddorUpdateParentCategory(category.CategoryId, ParentList);//ای دی دسته بندی که ذخیره کردیم ووالد هاش را میفرستیم
                }
                return true;
            }
            return false;

        }

        public void AddorUpdateParentCategory(int SubcatId, List<int> newParentList)
        {
            // در اینجا خود دسته بندی میشه ساب کتگوری که اینجا آی دی ان را فرستادیم و لیست والدهایی که مدیر انتخاب کرده برای این ساب کتگوری
            List<SubCategory> RemoveList = new List<SubCategory>();
            List<SubCategory> AddList = new List<SubCategory>();
            List<SubCategory> parentlist = dB.subCategories.AsNoTracking().Where(s => s.SubId == SubcatId).ToList();//اگر والد داشته باشه در فیلد ساب آی دی وجود دارد وفیلد های ان را در این لیست میریزد
            if (parentlist.Count > 0)//اگر این شرط درست بود یعنی قبلا برای این دسته بندی والد ذخیره شده وباید این دسته بندی را حذف کنیم
            {
                
                foreach (var item in parentlist)
                {
                    if(newParentList != null)
                    {
                        if (newParentList.Contains(item.ParentId))//اگر والد این ساب کتگوری در لیست والدهای انتخابی توسط کاربر وجود دارد 
                        {
                            newParentList.Remove(item.ParentId);//این والد را از لیست انتخابی ها حذف کن تا تکراری ذخیره نشود
                        }
                        else
                        {
                            RemoveList.Add(new SubCategory
                            {
                                SubCategoryId = item.SubCategoryId//در غیر این صورت این دسته بندی را به این لیست اضافه کن
                            });
                        }
                    }
                    else
                    {
                        RemoveList.Add(new SubCategory
                        {
                            SubCategoryId = item.SubCategoryId//در غیر این صورت این دسته بندی را به این لیست اضافه کن
                        });
                    }

                }
                if(newParentList != null && newParentList.Count > 0)//اگر لیست والد ها خالی نبود وبزرگتر از صفر بود یعنی یک والد از قبل در ان وجود داشته شاید مدیر ساب کتگوری را حذف کرده و والد ها را حذف نکرده چون اینجا لیست است و لیست ها از صفر شروع میشوند گفتیم بزرگتر از صفر
                {
                    foreach (var item in newParentList)
                    {
                        if (!dB.subCategories.Any(s => s.SubId == SubcatId && s.ParentId == item))//برای چک کردن این که کاربر دستی آی دی دسته بندی را تغیر ندهد
                        {
                            AddList.Add(new SubCategory
                            {
                                SubId = SubcatId,
                                ParentId = item
                            });
                        }

                    }

                }
                dB.RemoveRange(RemoveList);//این لیست والد را حذف کن که تکراری ذخیره نشود

            }
            else
            {


                if (newParentList != null)//در غیر این صورت اگر لیست والد ها خالی نبود
                {
                    foreach (var item in newParentList)
                    {
                        if (!dB.subCategories.Any(s => s.SubId == SubcatId && s.ParentId == item))
                        {
                            AddList.Add(new SubCategory
                            {
                                SubId = SubcatId,
                                ParentId = item
                            });
                        }

                    }
                    
                }
            }
            dB.AddRange(AddList);
            dB.SaveChanges();

        }

        public List<int> GetSubCategory(int id)
        {
            return dB.subCategories.Where(s => s.SubId == id).Select(c => c.ParentId).ToList();
            //چک میکنیم که ایا کتگوری انتخاب شده توسط کاربر در فیلد ساب کتگوری ها هست یا نه اگر باشد حتما والد دارد و والد ان را بر میگردانیم
        }
        public bool IsExsitCategoryTitle(int Catid,string CatName)
        {
            return dB.categories.Any(s => s.CategoryId != Catid && s.CatName == CatName);

        }

        public bool UpdateCategory(Category category,List<int>Parentlist)
        {
            dB.Update(category);
            var res = dB.SaveChanges();
            if (res > 0)
            {
                AddorUpdateParentCategory(category.CategoryId, Parentlist);
                
              return true;
            }
                
            return false;
        }

        public List<int> GetParentCategory(int id)
        {
            List<int> ParentList = new List<int>();
            List<int> temp = new List<int>();
            List<int> temp2 = dB.subCategories.AsNoTracking().Where(s => s.SubId == id).Select(s => s.ParentId).ToList();
        Label1: ParentList.AddRange(temp2);
            temp.Clear();
            temp.AddRange(temp2);
            temp2.Clear();
            foreach (var item in temp)
            {
                temp2.AddRange(dB.subCategories.AsNoTracking().Where(s => s.SubId == item).Select(s => s.ParentId).ToList());
                if (item.Equals(temp.Last()))
                    goto Label1;
            }
            return ParentList.Distinct().ToList();

        }

        public bool AddProductCategories(List<ProductCategory> productCategory)
        {
            dB.AddRange(productCategory);
            int res = dB.SaveChanges();
            if(res >0)
                return true;
            return false;
        }



    }
}
