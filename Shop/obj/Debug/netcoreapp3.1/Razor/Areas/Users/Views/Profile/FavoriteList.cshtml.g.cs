#pragma checksum "C:\Users\abbas\source\repos\Shop\Shop\Areas\Users\Views\Profile\FavoriteList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40aacb331d4df303ad506c57a1d6e4247bf482c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Profile_FavoriteList), @"mvc.1.0.view", @"/Areas/Users/Views/Profile/FavoriteList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Users\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Users\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Users\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Users\Views\_ViewImports.cshtml"
using Shop.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40aacb331d4df303ad506c57a1d6e4247bf482c9", @"/Areas/Users/Views/Profile/FavoriteList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0819dd18e331905c0f8118f4f345cf0db80bd1", @"/Areas/Users/Views/_ViewImports.cshtml")]
    public class Areas_Users_Views_Profile_FavoriteList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FavoriteListForProfileViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Users\Views\Profile\FavoriteList.cshtml"
  
    ViewData["Title"] = "FavoriteList";
    Layout = "~/Areas/Users/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content\">\r\n    ");
#nullable restore
#line 8 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Users\Views\Profile\FavoriteList.cshtml"
Write(await Html.PartialAsync("FavoriteListContent", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FavoriteListForProfileViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
