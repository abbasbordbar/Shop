#pragma checksum "C:\Users\abbas\source\repos\Shop\Shop\Views\Shared\Components\ProductPropertyComp\ProductPropertyComp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894b195a07a4da6b12bcf117997840ac04306e0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductPropertyComp_ProductPropertyComp), @"mvc.1.0.view", @"/Views/Shared/Components/ProductPropertyComp/ProductPropertyComp.cshtml")]
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
#line 1 "C:\Users\abbas\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abbas\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abbas\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894b195a07a4da6b12bcf117997840ac04306e0b", @"/Views/Shared/Components/ProductPropertyComp/ProductPropertyComp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8059af928940689afdb014d21b81c83fd9b52adf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductPropertyComp_ProductPropertyComp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.ViewModels.ProductPropertyViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\abbas\source\repos\Shop\Shop\Views\Shared\Components\ProductPropertyComp\ProductPropertyComp.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-bottom:200px\">\r\n");
#nullable restore
#line 8 "C:\Users\abbas\source\repos\Shop\Shop\Views\Shared\Components\ProductPropertyComp\ProductPropertyComp.cshtml"
     foreach (var item in Model.GroupBy(g=>g.GroupName))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"text-align:right;margin-bottom:100px;font-family:\'B Titr\'\">");
#nullable restore
#line 10 "C:\Users\abbas\source\repos\Shop\Shop\Views\Shared\Components\ProductPropertyComp\ProductPropertyComp.cshtml"
                                                                         Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 11 "C:\Users\abbas\source\repos\Shop\Shop\Views\Shared\Components\ProductPropertyComp\ProductPropertyComp.cshtml"
        foreach (var item2 in item.ToList())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"" style=""direction:rtl;margin-right:200px"">

    
                <div class=""col-md-6"">
                     <ul class=""list-group list-group-horizontal"">
                         <li class=""list-group-item"" style=""width:200px;text-align:right;margin-left:3px"">");
#nullable restore
#line 18 "C:\Users\abbas\source\repos\Shop\Shop\Views\Shared\Components\ProductPropertyComp\ProductPropertyComp.cshtml"
                                                                                                     Write(item2.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                         <li class=\"list-group-item\">");
#nullable restore
#line 19 "C:\Users\abbas\source\repos\Shop\Shop\Views\Shared\Components\ProductPropertyComp\ProductPropertyComp.cshtml"
                                                Write(item2.PropertyValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                      </ul> \r\n                  \r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\abbas\source\repos\Shop\Shop\Views\Shared\Components\ProductPropertyComp\ProductPropertyComp.cshtml"

        }

        

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.ViewModels.ProductPropertyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
