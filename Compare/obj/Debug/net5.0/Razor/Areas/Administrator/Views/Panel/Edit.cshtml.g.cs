#pragma checksum "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b44f2c45aec0589b24137616c81c6b9b87af1d55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Panel_Edit), @"mvc.1.0.view", @"/Areas/Administrator/Views/Panel/Edit.cshtml")]
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
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
using Compare.BLL.DTOs.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
using Compare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
using Compare.Utilits;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b44f2c45aec0589b24137616c81c6b9b87af1d55", @"/Areas/Administrator/Views/Panel/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639ff3e55e44189a11449fae1f19354e5a7eab68", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Panel_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Compare.BLL.DTOs.Panel.EditPanelDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Panel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Editing panel"];
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

    int lngIndex = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"py-4\">\r\n    <div class=\"d-flex justify-content-between w-100 flex-wrap\">\r\n        <div class=\"mb-3 mb-lg-0\">\r\n            <h1 class=\"h4\">");
#nullable restore
#line 19 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                      Write(SharedLocalizer["Editing panel"]);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b44f2c45aec0589b24137616c81c6b9b87af1d558056", async() => {
                WriteLiteral("\r\n                            <div class=\"col-lg-12 col-sm-12\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b44f2c45aec0589b24137616c81c6b9b87af1d558413", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 32 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
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
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b44f2c45aec0589b24137616c81c6b9b87af1d5510131", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 33 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 35 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                 foreach (LanguageDTO languageDTO in ViewBag.Languages)
                                {
                                    var plT = Model.PanelTranslates.FirstOrDefault(p => p.LanguageCulture == languageDTO.Culture);


#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1608, "\"", 1657, 3);
                WriteAttributeValue("", 1615, "PanelTranslates[", 1615, 16, true);
#nullable restore
#line 39 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
WriteAttributeValue("", 1631, lngIndex, 1631, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1640, "].LanguageCulture", 1640, 17, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1658, "\"", 1686, 1);
#nullable restore
#line 39 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
WriteAttributeValue("", 1666, languageDTO.Culture, 1666, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("                                    <h2>");
#nullable restore
#line 41 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                   Write(languageDTO.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                    <hr />\r\n");
#nullable restore
#line 43 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                     if (plT != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1956, "\"", 1992, 3);
                WriteAttributeValue("", 1963, "PanelTranslates[", 1963, 16, true);
#nullable restore
#line 45 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
WriteAttributeValue("", 1979, lngIndex, 1979, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1988, "].Id", 1988, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1993, "\"", 2008, 1);
#nullable restore
#line 45 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
WriteAttributeValue("", 2001, plT.Id, 2001, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <div class=\"mb-3\">\r\n                                            <label>");
#nullable restore
#line 47 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                              Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                            <div");
                BeginWriteAttribute("id", " id=\"", 2209, "\"", 2228, 2);
                WriteAttributeValue("", 2214, "name-", 2214, 5, true);
#nullable restore
#line 48 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
WriteAttributeValue("", 2219, lngIndex, 2219, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                        </div>\r\n                                        <script>\r\n                                            $(function () {\r\n                                                $(\"#name-");
#nullable restore
#line 52 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                                    Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").dxTextBox({\r\n                                                    name: \"PanelTranslates[");
#nullable restore
#line 53 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                                                      Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("].Name\",\r\n                                                    value: ");
#nullable restore
#line 54 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                                      Write(Json.Serialize(plT.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                    }).dxValidator({
                                                        validationRules: [{
                                                            type: ""required"",
                                                            message: '");
#nullable restore
#line 58 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                                                 Write(SharedLocalizer["Enter name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                                                        }]\r\n                                                    }).dxTextBox(\"instance\");\r\n                                            });\r\n                                        </script>\r\n");
#nullable restore
#line 63 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"mb-3\">\r\n                                            <label>");
#nullable restore
#line 67 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                              Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                            <div");
                BeginWriteAttribute("id", " id=\"", 3542, "\"", 3569, 2);
                WriteAttributeValue("", 3547, "product-name-", 3547, 13, true);
#nullable restore
#line 68 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
WriteAttributeValue("", 3560, lngIndex, 3560, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                        </div>\r\n                                        <script>\r\n                                            $(function () {\r\n                                                $(\"#name-");
#nullable restore
#line 72 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                                    Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").dxTextBox({\r\n                                                    name: \"PanelTranslates[");
#nullable restore
#line 73 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
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
#line 77 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
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
#line 83 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                     

                                    lngIndex++;
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <h2>");
#nullable restore
#line 88 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                               Write(SharedLocalizer["Data"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                <hr />\r\n                                <div class=\"mb-3\">\r\n                                    <label>");
#nullable restore
#line 91 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                      Write(SharedLocalizer["Products"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                    <div id=\"productSelection\"</div>\r\n                                </div>\r\n                                <div class=\"mb-3\">\r\n                                    <label>");
#nullable restore
#line 95 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                                      Write(SharedLocalizer["Sorting"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        let getProducts = `");
#nullable restore
#line 118 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                      Write(API.GetAllProducts);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;

        $(function () {
            $(""#productSelection"").dxTagBox({
                dataSource: new DevExpress.data.DataSource({
                    store: new DevExpress.data.AspNet.createStore({
                        key: ""id"",
                        loadUrl: getProducts,
                        loadMode: ""raw"",
                        onBeforeSend: function (method, ajaxOptions) {
                            ajaxOptions.xhrFields = { withCredentials: true };
                        }
                    }),
                    paginate: true,
                    pageSize: 30
                }),
                searchEnabled: true,
                displayExpr: ""productName"",
                valueExpr: ""id"",
                name: ""ProductsId"",
                value: ");
#nullable restore
#line 138 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                  Write(Html.Raw(Json.Serialize(Model.ProductsId)));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 142 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                         Write(SharedLocalizer["Select products"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n\r\n            $(\"#displayOrder\").dxNumberBox({\r\n                value: 0,\r\n                min: 0,\r\n                showSpinButtons: true,\r\n                name: \'DisplayOrder\',\r\n                value: ");
#nullable restore
#line 151 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                  Write(Json.Serialize(Model.DisplayOrder));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 155 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                         Write(SharedLocalizer["Enter sort number"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n\r\n            let published = \'");
#nullable restore
#line 159 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                        Write(Model.IsPublish);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n            $(\"#isPublish\").dxCheckBox({\r\n                value: true,\r\n                text: \'");
#nullable restore
#line 162 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                  Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \'IsPublish\',\r\n                value: (published.toLowerCase() == \'true\')\r\n            });\r\n\r\n            $(\"#button\").dxButton({\r\n                text: \'");
#nullable restore
#line 168 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Panel\Edit.cshtml"
                  Write(SharedLocalizer["Edit"]);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Compare.BLL.DTOs.Panel.EditPanelDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591