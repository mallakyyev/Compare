#pragma checksum "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc7f6ace620153eb87422e621479d0ed21755a0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Detail), @"mvc.1.0.view", @"/Views/Store/Detail.cshtml")]
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
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc7f6ace620153eb87422e621479d0ed21755a0e", @"/Views/Store/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639ff3e55e44189a11449fae1f19354e5a7eab68", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Compare.BLL.DTOs.Organization.OrganizationDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Content -->\r\n<div id=\"content\">\r\n    <!-- Contact -->\r\n    <section class=\"contact-sec padding-top-40 padding-bottom-80\">\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 15 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
             if (ViewBag.AlertMessage == "success")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-success alert-dismissible show\">\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\">??</button>\r\n                    <strong>");
#nullable restore
#line 19 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                       Write(SharedLocalizer["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</strong> ");
#nullable restore
#line 19 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                                             Write(SharedLocalizer["Your review about the store will appear after being checked by the moderator"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 21 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
            }
            else if (ViewBag.AlertMessage == "danger")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger alert-dismissible show\">\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\">??</button>\r\n                    <strong>");
#nullable restore
#line 26 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                       Write(SharedLocalizer["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</strong> ");
#nullable restore
#line 26 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                                           Write(SharedLocalizer["Failed to add store review"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!-- Conatct -->
            <div class=""contact"">
                <div class=""contact-form"">
                    <div class=""row"">
                        <div class=""col-md-8"">

                            <div class=""heading"">
                                <h1>");
#nullable restore
#line 36 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            </div>\r\n                            <div class=\"blog-post\">\r\n                                <article>\r\n                                    ");
#nullable restore
#line 40 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                               Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </article>\r\n                            </div>\r\n                            <div class=\"comments\">\r\n                                <h5>");
#nullable restore
#line 44 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                               Write(SharedLocalizer["Comments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 44 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                                             Write(Model.StoreComments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                                <hr />\r\n");
#nullable restore
#line 46 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                 if (User.Identity.IsAuthenticated)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"add-comments padding-top-20\">\r\n                                        <h6>");
#nullable restore
#line 49 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                       Write(SharedLocalizer["Tell us in detail about your impressions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <!-- FORM -->\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7f6ace620153eb87422e621479d0ed21755a0e10405", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"OrganizationId\"");
                BeginWriteAttribute("value", " value=\"", 2535, "\"", 2552, 1);
#nullable restore
#line 52 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
WriteAttributeValue("", 2543, Model.Id, 2543, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                            <ul class=\"row\">\r\n                                                <li class=\"col-sm-6\">\r\n                                                    <label>\r\n                                                        ");
#nullable restore
#line 56 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                                   Write(SharedLocalizer["Heading"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                        <input type=\"text\" class=\"form-control\" name=\"Name\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2944, "\"", 2958, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 2959, "\"", 3003, 1);
#nullable restore
#line 57 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
WriteAttributeValue("", 2970, SharedLocalizer["Enter heading"], 2970, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                    </label>
                                                </li>
                                                <li class=""col-sm-12"">
                                                    <label>
                                                        ");
#nullable restore
#line 62 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                                   Write(SharedLocalizer["Your feedback"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                        <textarea class=\"form-control\" rows=\"3\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3443, "\"", 3457, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"Description\"");
                BeginWriteAttribute("required", " required=\"", 3477, "\"", 3527, 1);
#nullable restore
#line 63 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
WriteAttributeValue("", 3488, SharedLocalizer["Enter your feedback"], 3488, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                                                    </label>
                                                </li>
                                                <li class=""col-sm-12 text-left"">
                                                    <button type=""submit"" class=""btn-round"">");
#nullable restore
#line 67 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                                                                       Write(SharedLocalizer["Send comment"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                                </li>\r\n                                            </ul>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <hr />\r\n");
#nullable restore
#line 73 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ul>\r\n");
#nullable restore
#line 75 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                     foreach (var comment in Model.StoreComments)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"media\">\r\n                                            <div class=\"media-body\">\r\n                                                <h6>");
#nullable restore
#line 79 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                               Write(comment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span><i class=\"fa fa-bookmark-o\"></i> ");
#nullable restore
#line 79 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                                                                                    Write(comment.PublicateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </h6>\r\n                                                <p>");
#nullable restore
#line 80 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                              Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </li>\r\n");
#nullable restore
#line 83 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>

                        <!-- Conatct Infomation -->
                        <div class=""col-md-4"">
                            <div class=""contact-info"">
                                <h5>");
#nullable restore
#line 91 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5><br />\r\n                                <p>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc7f6ace620153eb87422e621479d0ed21755a0e18902", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5211, "~/images/organizations/", 5211, 23, true);
#nullable restore
#line 93 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
AddHtmlAttributeValue("", 5234, Model.Logo, 5234, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </p>\r\n                                <hr>\r\n                                <h6> ");
#nullable restore
#line 96 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                Write(SharedLocalizer["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h6>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 98 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                               Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <h6>");
#nullable restore
#line 100 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                               Write(SharedLocalizer["Phone"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h6>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 102 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                               Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <h6>");
#nullable restore
#line 104 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                               Write(SharedLocalizer["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h6>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 106 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <h6>");
#nullable restore
#line 108 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                               Write(SharedLocalizer["Site"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h6>\r\n                                <p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6079, "\"", 6099, 2);
            WriteAttributeValue("", 6086, "//", 6086, 2, true);
#nullable restore
#line 110 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
WriteAttributeValue("", 6088, Model.Site, 6088, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 110 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Store\Detail.cshtml"
                                                                       Write(Model.Site);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n<!-- End Content --> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Compare.BLL.DTOs.Organization.OrganizationDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
