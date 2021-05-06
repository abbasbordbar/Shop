using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Areas.Identity.Data;
using Shop.Models;

namespace Shop.Data
{
    public class DBShop : IdentityDbContext<ApplicationUser>
    {
        private object modelBuilder;
        #region Product 
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImg> productImgs { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductRating> ProductRatings { get; set; }
        public DbSet<PropertyGroup> PropertyGroups { get; set; }
        public DbSet<PropertyName> PropertyNames { get; set; }
        public DbSet<PropertyValue> PropertyValues { get; set; }
        public DbSet<ProductProperty> ProductProperties { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        #endregion
        #region category
        public DbSet<Category> categories { get; set; }
        public DbSet<SubCategory> subCategories { get; set; }
        public DbSet<CategoryAttribut> categoryAttributs { get; set; }
        #endregion
        #region Brand
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandCategory> BrandCategories { get; set; }
        #endregion
        #region Comment
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentLike> CommentLikes { get; set; }
        #endregion
        #region User
        public DbSet<User> users { get; set; }
        public DbSet<UserProductFavorite> UserProductFavorites { get; set; }
        #endregion
        #region Address
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Provinc> Provincs { get; set; }
        public DbSet<City> Cities { get; set; }
        #endregion
        #region Menu
        public DbSet<MainMenu> MainMenus { get; set; }
        #endregion
        #region Banner
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BannerImage> BannerImages { get; set; }
        #endregion





        public DBShop(DbContextOptions<DBShop> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasQueryFilter(c => !c.IsDelete);
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            var cascadeFKs = builder.Model.GetEntityTypes()
               .SelectMany(t => t.GetForeignKeys())
               .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(builder);
        }
    }
}
