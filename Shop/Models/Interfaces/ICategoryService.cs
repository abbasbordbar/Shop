using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
   public interface ICategoryService
    {
        Category GetCategoryByName(string CatName);

        List<Category> GetSubCategoryById(int CategoryId);
        CategoryViewModel GetSubCategoryByName(string CategoryName);
        List<Category> CategoryForAdmin();
        bool DeleteCategory(Category category);
        Category FindCategoryById(int id);
        List<GetCategoryForAddViewModel> GetCategoryForAdd();
        bool AddCategory(Category category, List<int> ParentList);
        void AddorUpdateParentCategory(int SubcatId, List<int> ParentList);
        List<int> GetSubCategory(int id);
        bool IsExsitCategoryTitle(int Catid, string CatName);
        bool UpdateCategory(Category category, List<int> Parentlist);
        List<int> GetParentCategory(int id);
        bool AddProductCategories(List<ProductCategory> productCategory);
    }
}
