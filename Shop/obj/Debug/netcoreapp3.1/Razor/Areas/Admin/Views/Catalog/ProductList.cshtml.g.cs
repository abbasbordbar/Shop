#pragma checksum "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eff4dc07bbcb22caee9163887c742779d49db508"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Catalog_ProductList), @"mvc.1.0.view", @"/Areas/Admin/Views/Catalog/ProductList.cshtml")]
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
#line 1 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eff4dc07bbcb22caee9163887c742779d49db508", @"/Areas/Admin/Views/Catalog/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0819dd18e331905c0f8118f4f345cf0db80bd1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Catalog_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.ViewModels.ProductListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GalleryList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Layout/js/jquery.unobtrusive-ajax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
  
    ViewData["Title"] = "ProductList";
    Layout = null;
    int PageCount = (int)Math.Ceiling((double)ViewBag.Count / 2);
    int Pagenumber = ViewBag.PageNumber;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"productlist\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
               Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                   Write(Html.Raw((String.IsNullOrEmpty(item.Image) ? "" : "<img src='/Layout/img/MainImg/" + item.Image + "'class='thumbnail' width='150'/>")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eff4dc07bbcb22caee9163887c742779d49db5088111", async() => {
                WriteLiteral("??????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 43 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n\r\n\r\n    <!---------Pagination-->\r\n    <div class=\"container\" style=\"margin-right:40%\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 56 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
             if (PageCount > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 60 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                         if (PageCount > 10)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                             if (Pagenumber <= 5)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                 if (Pagenumber != 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""page-item"">
                                        <a class=""page-link js-paper_item"" data-pagenumber=""1"" aria-label=""Previous"">
                                            <span aria-hidden=""true"">&laquo;</span>
                                        </a>
                                    </li>
");
#nullable restore
#line 71 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                 for (int i = 1; i <= Pagenumber + 5; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item \">\r\n                                        <a");
            BeginWriteAttribute("class", " class=\"", 2805, "\"", 2867, 2);
            WriteAttributeValue("", 2813, "page-link", 2813, 9, true);
#nullable restore
#line 76 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
WriteAttributeValue("  ", 2822, i==Pagenumber ? "active":"js-paper_item", 2824, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-pagenumber=\"");
#nullable restore
#line 76 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 76 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 78 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                 if (PageCount != Pagenumber)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link js-paper_item\" data-pagenumber=\"");
#nullable restore
#line 83 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                       Write(PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-label=\"Next\">\r\n                                            <span aria-hidden=\"true\">&raquo;</span>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 87 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                 


                            }
                            else
                            {
                                if (Pagenumber + 5 > PageCount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""page-item"">
                                        <a class=""page-link js-paper_item"" data-pagenumber=""1"" href=""#"" aria-label=""Previous"">
                                            <span aria-hidden=""true"">&laquo;</span>
                                        </a>
                                    </li>
");
#nullable restore
#line 101 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                     for (int i = PageCount - 9; i <= PageCount; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item \">\r\n                                            <a");
            BeginWriteAttribute("class", " class=\"", 4270, "\"", 4332, 2);
            WriteAttributeValue("", 4278, "page-link", 4278, 9, true);
#nullable restore
#line 104 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
WriteAttributeValue("  ", 4287, i==Pagenumber ? "active":"js-paper_item", 4289, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-pagenumber=\"");
#nullable restore
#line 104 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">");
#nullable restore
#line 104 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </li>\r\n");
#nullable restore
#line 106 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                     if (PageCount != Pagenumber)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item\">\r\n                                            <a class=\"page-link js-paper_item\" data-pagenumber=\"");
#nullable restore
#line 110 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                           Write(PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\" aria-label=\"Next\">\r\n                                                <span aria-hidden=\"true\">&raquo;</span>\r\n                                            </a>\r\n                                        </li>\r\n");
#nullable restore
#line 114 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                     


                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""page-item"">
                                        <a class=""page-link js-paper_item"" data-pagenumber=""1"" href=""#"" aria-label=""Previous"">
                                            <span aria-hidden=""true"">&laquo;</span>
                                        </a>
                                    </li>
");
#nullable restore
#line 126 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                     for (int i = Pagenumber - 5; i < Pagenumber + 5; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item \">\r\n                                            <a");
            BeginWriteAttribute("class", " class=\"", 5708, "\"", 5770, 2);
            WriteAttributeValue("", 5716, "page-link", 5716, 9, true);
#nullable restore
#line 129 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
WriteAttributeValue("  ", 5725, i==Pagenumber ? "active":"js-paper_item", 5727, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-pagenumber=\"");
#nullable restore
#line 129 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">");
#nullable restore
#line 129 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </li>\r\n");
#nullable restore
#line 131 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link js-paper_item\" data-pagenumber=\"");
#nullable restore
#line 133 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                       Write(PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\" aria-label=\"Next\">\r\n                                            <span aria-hidden=\"true\">&raquo;</span>\r\n                                        </a>\r\n\r\n                                    </li>\r\n");
#nullable restore
#line 138 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                             
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                             if (Pagenumber != 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""page-item"">
                                    <a class=""page-link js-paper_item"" data-pagenumber=""1"" href=""#"" aria-label=""Previous"">
                                        <span aria-hidden=""true"">&laquo;</span>
                                    </a>
                                </li>
");
#nullable restore
#line 150 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                             for (int i = 1; i <= PageCount; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item \">\r\n                                    <a");
            BeginWriteAttribute("class", " class=\"", 7065, "\"", 7127, 2);
            WriteAttributeValue("", 7073, "page-link", 7073, 9, true);
#nullable restore
#line 155 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
WriteAttributeValue("  ", 7082, i==Pagenumber ? "active":"js-paper_item", 7084, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-pagenumber=\"");
#nullable restore
#line 155 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">");
#nullable restore
#line 155 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 157 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                             if (PageCount != Pagenumber)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a class=\"page-link js-paper_item\" data-pagenumber=\"");
#nullable restore
#line 162 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                                   Write(PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\" aria-label=\"Next\">\r\n                                        <span aria-hidden=\"true\">&raquo;</span>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 166 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </ul>\r\n                </nav>\r\n");
#nullable restore
#line 173 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eff4dc07bbcb22caee9163887c742779d49db50827973", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    $(\'#productlist\').delegate(\".js-paper_item\", \"click\", function () {\r\n        var Pagenumber = parseInt($(this).data(\"pagenumber\"))\r\n        $(\'#list\').load(\"/Admin/Catalog/ProductList\", { searchtext: \'");
#nullable restore
#line 183 "C:\Users\abbas\source\repos\Shop\Shop\Areas\Admin\Views\Catalog\ProductList.cshtml"
                                                                Write(ViewBag.searchtext);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', Pagenumber: Pagenumber })\r\n            });\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.ViewModels.ProductListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
