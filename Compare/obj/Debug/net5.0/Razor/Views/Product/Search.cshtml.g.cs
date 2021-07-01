#pragma checksum "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a0141b9e4fa9ced699dc4ce280ec2614b905e13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Search), @"mvc.1.0.view", @"/Views/Product/Search.cshtml")]
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
#line 1 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\_ViewImports.cshtml"
using Compare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\_ViewImports.cshtml"
using Compare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a0141b9e4fa9ced699dc4ce280ec2614b905e13", @"/Views/Product/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639ff3e55e44189a11449fae1f19354e5a7eab68", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-round"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Compare.TagHelpers.PageLinkTagHelper __Compare_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
  
    ViewData["Title"] = Model.SearchText;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Content -->\r\n<div id=\"content\">\r\n\r\n    <!-- Products -->\r\n    <section class=\"padding-top-40 padding-bottom-60\">\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 17 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
             if (Model.ProductDTOs.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <!-- Products -->\r\n                    <div class=\"col-md-12\">\r\n\r\n                        <!-- Short List -->\r\n                        <div class=\"short-lst\">\r\n                            <h2>");
#nullable restore
#line 25 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                           Write(Model.SearchText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </div>\r\n\r\n                        <!-- Items -->\r\n                        <div class=\"col-list\">\r\n                            <!-- Product -->\r\n");
#nullable restore
#line 31 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                             foreach (var product in Model.ProductDTOs.OrderBy(o => o.DisplayOrder))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""product"">
                                    <article>
                                        <!-- Product img -->
                                        <div class=""media-left"">
                                            <div class=""item-img"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a0141b9e4fa9ced699dc4ce280ec2614b905e137904", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1408, "~/images/products/L/", 1408, 20, true);
#nullable restore
#line 38 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
AddHtmlAttributeValue("", 1428, product.Image, 1428, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <!-- Content -->
                                        <div class=""media-body"">
                                            <div class=""row"">
                                                <!-- Content Left -->
                                                <div class=""col-sm-7"">
                                                    <div class=""product-title"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a0141b9e4fa9ced699dc4ce280ec2614b905e1310148", async() => {
#nullable restore
#line 47 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                                                                                                                 Write(product.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                                                                                             WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </div>\r\n\r\n                                                    <div class=\"product-shortdescription\">\r\n                                                        ");
#nullable restore
#line 51 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                   Write(product.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </div>
                                                </div>
                                                <!-- Content Right -->
                                                <div class=""col-sm-5 text-center"">
                                                    <div class=""position-center-center"">
");
#nullable restore
#line 57 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                         if (product.MinPrice > 0)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"price\">от ");
#nullable restore
#line 59 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                                             Write(product.MinPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TMT</div>\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a0141b9e4fa9ced699dc4ce280ec2614b905e1314812", async() => {
#nullable restore
#line 60 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                                                                                                                                       Write(product.CountOffers);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 60 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                                                                                                                                                             Write((product.CountOffers > 1) ? SharedLocalizer["offers"] : SharedLocalizer["offer"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                                                                                                 WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"product-notavailable\">\r\n                                                                ");
#nullable restore
#line 65 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                           Write(SharedLocalizer["Not available"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </div>\r\n");
#nullable restore
#line 67 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </article>
                                </div>
");
#nullable restore
#line 74 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <!-- pagination -->\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a0141b9e4fa9ced699dc4ce280ec2614b905e1320228", async() => {
            }
            );
            __Compare_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::Compare.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__Compare_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 77 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
__Compare_TagHelpers_PageLinkTagHelper.PageModel = Model.PageViewModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Compare_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Compare_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Compare_TagHelpers_PageLinkTagHelper.PageUrlValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-text", "Compare.TagHelpers.PageLinkTagHelper", "PageUrlValues"));
            }
#nullable restore
#line 77 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
__Compare_TagHelpers_PageLinkTagHelper.PageUrlValues["text"] = Model.SearchText;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-text", __Compare_TagHelpers_PageLinkTagHelper.PageUrlValues["text"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 82 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <section>\r\n                    <div class=\"container\">\r\n                        <div class=\"order-success error-page\">\r\n                            <h3>");
#nullable restore
#line 88 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                           Write(SharedLocalizer["No results were found for your search"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>\r\n                                ");
#nullable restore
#line 90 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
                           Write(SharedLocalizer["Try to shorten the request or ask it differently. Make sure the product name is spelled correctly."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </section>\r\n");
#nullable restore
#line 95 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Product\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n\r\n</div>\r\n<!-- End Content --> ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResource> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
