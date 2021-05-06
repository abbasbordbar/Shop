using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop.Helpers;
using Shop.Models.Interfaces;
using Shop.Models.Services;
using Shop.Sender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public class Startup
    {
        public const string CookieScheme = "DigikalaCookie";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddNewtonsoftJson();

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductDetail, ProductDetailService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IMainMenuService, MainMenuService>();
            services.AddTransient<IBannerService, BannerService>();
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<IPropertyService, PropertyService>();
            services.AddTransient<IGalleryService, GalleryService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IEmailSender, MessageSender>();
            services.AddTransient<IRenderViewToString, RenderViewToString>();
            services.AddTransient<IAddressService,AddressService>();
            services.AddTransient<IFavoriteService, FavoriteService>();
            services.AddControllersWithViews();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddAuthentication(IISDefaults.AuthenticationScheme);

            services.AddAuthentication(CookieScheme)
                 .AddCookie(CookieScheme, options =>
                 {
                     options.AccessDeniedPath = "/Account/Login";
                     options.LoginPath = "/Account/Login";
                     options.ExpireTimeSpan = TimeSpan.FromDays(31);
                 });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseStatusCodePagesWithReExecute("/Error/PageNotFound");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute("default", "{controller=Home}/{action=Contact}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Contact}/{id?}");

                endpoints.MapControllerRoute(
                    name: "Users",
                    pattern: "{controller}/{action}/",
                    defaults: new { area = "Users", controller = "Profile", action = "index" });

            });


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            });

        }
    }
}
