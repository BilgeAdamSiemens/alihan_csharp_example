#pragma checksum "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8553c8ade729677f52b172a2ca62a08dbeeacecc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\_ViewImports.cshtml"
using ECommerce.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\_ViewImports.cshtml"
using ECommerce.WebUI.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8553c8ade729677f52b172a2ca62a08dbeeacecc", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32f85727a79b57a6e1ba1513cf3f947ed8822030", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\Product\List.cshtml"
  
    List<Product> products = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\Product\List.cshtml"
     foreach (Product product in products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6 col-xl-3\">\r\n            <div class=\"card-box product-box\">\r\n\r\n\r\n                <div class=\"bg-light\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8553c8ade729677f52b172a2ca62a08dbeeacecc4553", async() => {
                WriteLiteral("\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 380, "\"", 408, 2);
                WriteAttributeValue("", 386, "/img/", 386, 5, true);
#nullable restore
#line 17 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\Product\List.cshtml"
WriteAttributeValue("", 391, product.ImageUrl, 391, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"product-pic\" class=\"img-fluid\">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\Product\List.cshtml"
                                                                      WriteLiteral(product.Id);

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
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"product-info\">\r\n                    <div class=\"row align-items-center\">\r\n                        <div class=\"col\">\r\n                            <h5 class=\"font-16 mt-0 sp-line-1\"><a");
            BeginWriteAttribute("href", " href=\"", 710, "\"", 744, 2);
            WriteAttributeValue("", 717, "/Product/Detail/", 717, 16, true);
#nullable restore
#line 24 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\Product\List.cshtml"
WriteAttributeValue("", 733, product.Id, 733, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-dark\">");
#nullable restore
#line 24 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\Product\List.cshtml"
                                                                                                                  Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </h5>\r\n                            \r\n                            <h5 class=\"m-0\"> <span class=\"text-muted\"> Stocks : ");
#nullable restore
#line 26 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\Product\List.cshtml"
                                                                           Write(product.StockAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" pcs</span></h5>\r\n                        </div>\r\n                        <div class=\"col-auto\">\r\n                            <div class=\"product-price-tag\">\r\n                                ");
#nullable restore
#line 30 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\Product\List.cshtml"
                           Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("₺\r\n                            </div>\r\n                        </div>\r\n                    </div> <!-- end row -->\r\n                </div> <!-- end product info-->\r\n            </div> <!-- end card-box-->\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\Z0048KEM\source\repos\ECommerce\ECommerce.WebUI\Views\Product\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>  ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
