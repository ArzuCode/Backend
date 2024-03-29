#pragma checksum "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18322fc2f8b8f30d3976d991d0523f6cb2353c4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\_ViewImports.cshtml"
using Amado.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\_ViewImports.cshtml"
using Amado.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\_ViewImports.cshtml"
using Amado.MVC.Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\_ViewImports.cshtml"
using Amado.BLL.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\_ViewImports.cshtml"
using Amado.Core.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\_ViewImports.cshtml"
using Amado.MVC.Areas.Admin.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\_ViewImports.cshtml"
using Amado.MVC.Areas.Admin.Models.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\_ViewImports.cshtml"
using Amado.MVC.Areas.Admin.Models.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18322fc2f8b8f30d3976d991d0523f6cb2353c4d", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2154de580dffbc28fd734f51d1e2818b446362", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Categories";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Category Area Start -->\r\n<div class=\"products-catagories-area clearfix mt-2\">\r\n    <div class=\"col-sm-12 text-center\">\r\n        <h3>Categories</h3>\r\n    </div>\r\n    <div class=\"amado-pro-catagory clearfix\">\r\n       \r\n");
#nullable restore
#line 14 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\Category\Index.cshtml"
         foreach (var category in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Single Category -->\r\n            <div class=\"single-products-catagory clearfix\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18322fc2f8b8f30d3976d991d0523f6cb2353c4d5724", async() => {
                WriteLiteral("\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 569, "\"", 617, 1);
#nullable restore
#line 19 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\Category\Index.cshtml"
WriteAttributeValue("", 575, category.Products[0].ProductImages[0].Url, 575, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 618, "\"", 664, 2);
#nullable restore
#line 19 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\Category\Index.cshtml"
WriteAttributeValue("", 624, category.Products[0].ProductName, 624, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 657, "_Image", 658, 7, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <!-- Hover Content -->\r\n                    <div class=\"hover-content\">\r\n                        <div class=\"line\"></div>\r\n                        <p>");
#nullable restore
#line 23 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\Category\Index.cshtml"
                      Write(category.Products[0].Price.ToString("C2"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \'as from</p>\r\n                        <h4>");
#nullable restore
#line 24 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\Category\Index.cshtml"
                       Write(category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\Category\Index.cshtml"
                                                                   WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\user\Desktop\AmadoBackEndProject\Amado.MVC\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<!-- Category Area End -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
