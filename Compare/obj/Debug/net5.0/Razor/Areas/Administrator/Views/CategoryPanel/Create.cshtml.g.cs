#pragma checksum "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4b14149492ca1f61a4dc76164a9fb0f93a007b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_CategoryPanel_Create), @"mvc.1.0.view", @"/Areas/Administrator/Views/CategoryPanel/Create.cshtml")]
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
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\_ViewImports.cshtml"
using Compare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
using Compare.BLL.DTOs.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
using Compare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
using Compare.Utilits;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b14149492ca1f61a4dc76164a9fb0f93a007b5", @"/Areas/Administrator/Views/CategoryPanel/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639ff3e55e44189a11449fae1f19354e5a7eab68", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_CategoryPanel_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Compare.BLL.DTOs.CatalogPanel.CreateCategoryPanelDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CategoryPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Creating panel"];
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

    int lngIndex = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"py-4\">\r\n    <div class=\"d-flex justify-content-between w-100 flex-wrap\">\r\n        <div class=\"mb-3 mb-lg-0\">\r\n            <h1 class=\"h4\">");
#nullable restore
#line 19 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                      Write(SharedLocalizer["Creating panel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-12 mb-4"">
        <div class=""card border-light shadow-sm components-section"">
            <div class=""card-body"">
                <div id=""gridContainer"">
                    <div class=""row md-4"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4b14149492ca1f61a4dc76164a9fb0f93a007b57770", async() => {
                WriteLiteral("\r\n                            <div class=\"col-lg-12 col-sm-12\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4b14149492ca1f61a4dc76164a9fb0f93a007b58127", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 32 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 34 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                                 foreach (LanguageDTO languageDTO in ViewBag.Languages)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <h2>");
#nullable restore
#line 36 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                                   Write(languageDTO.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                    <hr />\r\n                                    <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1541, "\"", 1598, 3);
                WriteAttributeValue("", 1548, "CategoryPanelTranslates[", 1548, 24, true);
#nullable restore
#line 38 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
WriteAttributeValue("", 1572, lngIndex, 1572, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1581, "].LanguageCulture", 1581, 17, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1599, "\"", 1627, 1);
#nullable restore
#line 38 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
WriteAttributeValue("", 1607, languageDTO.Culture, 1607, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("                                    <div class=\"mb-3\">\r\n                                        <label>");
#nullable restore
#line 41 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                                          Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                        <div");
                BeginWriteAttribute("id", " id=\"", 1818, "\"", 1837, 2);
                WriteAttributeValue("", 1823, "name-", 1823, 5, true);
#nullable restore
#line 42 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
WriteAttributeValue("", 1828, lngIndex, 1828, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                    </div>\r\n                                    <script>\r\n                                            $(function () {\r\n                                                $(\"#name-");
#nullable restore
#line 46 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                                                    Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").dxTextBox({\r\n                                                    name: \"CategoryPanelTranslates[");
#nullable restore
#line 47 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                                                                              Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"].Name""
                                                    }).dxValidator({
                                                        validationRules: [{
                                                            type: ""required"",
                                                            message: '");
#nullable restore
#line 51 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                                                                 Write(SharedLocalizer["Enter name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                                                        }]
                                                    }).dxTextBox(""instance"");
                                            });
                                    </script>
                                    <br />
");
#nullable restore
#line 57 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"

                                    lngIndex++;
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <h2>");
#nullable restore
#line 61 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                               Write(SharedLocalizer["Data"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                <hr />\r\n                                <div class=\"mb-3\">\r\n                                    <label>");
#nullable restore
#line 64 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                                      Write(SharedLocalizer["Category"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div id=\"categorySelection\"></div>\r\n                                </div>\r\n                                <div class=\"mb-3\">\r\n                                    <label>");
#nullable restore
#line 68 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                                      Write(SharedLocalizer["Products"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div id=\"productSelection\"></div>\r\n                                </div>\r\n                                <div class=\"mb-3\">\r\n                                    <label>");
#nullable restore
#line 72 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                                      Write(SharedLocalizer["Sorting"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" *</label>
                                    <div id=""displayOrder""></div>
                                </div>
                                <div class=""mb-3"">
                                    <div id=""isPublish""></div>
                                </div>

                                <br />
                                <div id=""summary""></div>
                                <br />
                                <div id=""button""></div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        let getCategoryParents = `");
#nullable restore
#line 95 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                             Write(API.GetAllPublishCategoryParent);

#line default
#line hidden
#nullable disable
                WriteLiteral("`;\r\n        let getProducts = `");
#nullable restore
#line 96 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                      Write(API.GetProductCategoryParentList);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;

        $(function () {
            let categorySelectBox = $(""#categorySelection"").dxSelectBox({
                dataSource: new DevExpress.data.DataSource({
                    store: new DevExpress.data.AspNet.createStore({
                        key: ""id"",
                        loadUrl: getCategoryParents,
                        loadMode: ""raw"",
                        onBeforeSend: function (method, ajaxOptions) {
                            ajaxOptions.xhrFields = { withCredentials: true };
                        }
                    }),
                    paginate: true,
                    pageSize:30
                }),
                searchEnabled: true,
                displayExpr: ""name"",
                valueExpr: ""id"",
                name: ""CategoryId"",
                onValueChanged: function (data) {
                    productTagBox.option(""value"", """");
                    productTagBox.option(""disabled"", false);
                    productTagBox.option(""da");
                WriteLiteral(@"taSource"", new DevExpress.data.DataSource({
                        store: new DevExpress.data.AspNet.createStore({
                            key: ""id"",
                            loadUrl: getProducts + ""?parentId="" + categorySelectBox.option(""value""),
                            loadMode: ""raw"",
                            onBeforeSend: function (method, ajaxOptions) {
                                ajaxOptions.xhrFields = { withCredentials: true };
                            }
                        }),
                        paginate: true,
                        pageSize: 30
                    }));
                    //productTagBox.option(""dataSource"", new DevExpress.data.AspNet.createStore({
                    //    key: ""id"",
                    //    loadUrl: getProducts + ""?parentId="" + categorySelectBox.option(""value""),
                    //    onBeforeSend: function (method, ajaxOptions) {
                    //        ajaxOptions.xhrFields = { withCredentials: true };
");
                WriteLiteral("                    //    }\r\n                    //}));\r\n                }\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 142 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                         Write(SharedLocalizer["Select category"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                }]
            }).dxSelectBox(""instance"");

            let productTagBox = $(""#productSelection"").dxTagBox({
                disabled: true,
                searchEnabled: true,
                displayExpr: ""productName"",
                valueExpr: ""id"",
                name: ""ProductsId""
            }).dxValidator({
                validationRules: [{
                    type: ""required"",
                    message: '");
#nullable restore
#line 155 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                         Write(SharedLocalizer["Select products"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                }]
            }).dxTagBox(""instance"");

            $(""#displayOrder"").dxNumberBox({
                value: 0,
                min: 0,
                showSpinButtons: true,
                name: 'DisplayOrder',
            }).dxValidator({
                validationRules: [{
                    type: ""required"",
                    message: '");
#nullable restore
#line 167 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                         Write(SharedLocalizer["Enter sort number"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n\r\n            $(\"#isPublish\").dxCheckBox({\r\n                value: true,\r\n                text: \'");
#nullable restore
#line 173 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                  Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \'IsPublish\',\r\n            });\r\n\r\n            $(\"#button\").dxButton({\r\n                text: \'");
#nullable restore
#line 178 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\CategoryPanel\Create.cshtml"
                  Write(SharedLocalizer["Create"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                type: \"success\",\r\n                useSubmitBehavior: true,\r\n            });\r\n            $(\"#summary\").dxValidationSummary({});\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Compare.BLL.DTOs.CatalogPanel.CreateCategoryPanelDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
