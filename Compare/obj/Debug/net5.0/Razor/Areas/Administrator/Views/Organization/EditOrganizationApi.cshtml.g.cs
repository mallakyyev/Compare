#pragma checksum "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dccb47cd9a5c6198b7e9115187bb6f84dc3d640"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Organization_EditOrganizationApi), @"mvc.1.0.view", @"/Areas/Administrator/Views/Organization/EditOrganizationApi.cshtml")]
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
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
using Compare.BLL.DTOs.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
using Compare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
using Compare.Utilits;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dccb47cd9a5c6198b7e9115187bb6f84dc3d640", @"/Areas/Administrator/Views/Organization/EditOrganizationApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639ff3e55e44189a11449fae1f19354e5a7eab68", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Organization_EditOrganizationApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Compare.BLL.DTOs.Organization.EditOrganizationApiDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Organization", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditOrganizationApi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 9 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Editing a organization api"];
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

    int ctgIndex = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"py-4\">\r\n    <div class=\"d-flex justify-content-between w-100 flex-wrap\">\r\n        <div class=\"mb-3 mb-lg-0\">\r\n            <h1 class=\"h4\">");
#nullable restore
#line 19 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                      Write(SharedLocalizer["Editing a organization api"]);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dccb47cd9a5c6198b7e9115187bb6f84dc3d6408361", async() => {
                WriteLiteral("\r\n                            <div class=\"col-lg-12 col-sm-12\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dccb47cd9a5c6198b7e9115187bb6f84dc3d6408718", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 31 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7dccb47cd9a5c6198b7e9115187bb6f84dc3d64010458", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 32 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
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
                WriteLiteral("\r\n\r\n                                <h2>");
#nullable restore
#line 34 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                               Write(SharedLocalizer["Data"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                <hr />\r\n                                <div class=\"mb-3\">\r\n                                    <label>");
#nullable restore
#line 37 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                                      Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div id=\"name\"></div>\r\n                                </div>\r\n                                <div class=\"mb-3\">\r\n                                    <label>");
#nullable restore
#line 41 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                                      Write(SharedLocalizer["Categories"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div id=\"CategoriesId\">\r\n");
#nullable restore
#line 43 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                                         foreach (var cat in Model.CategoriesId)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 2059, "\"", 2089, 3);
                WriteAttributeValue("", 2066, "CategoriesId[", 2066, 13, true);
#nullable restore
#line 45 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
WriteAttributeValue("", 2079, ctgIndex, 2079, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2088, "]", 2088, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2090, "\"", 2102, 1);
#nullable restore
#line 45 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
WriteAttributeValue("", 2098, cat, 2098, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 46 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"

                                            ctgIndex++;
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n                                    <div id=\"treeBox\"></div>\r\n                                </div>\r\n                                <div class=\"mb-3\">\r\n                                    <label>");
#nullable restore
#line 53 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                                      Write(SharedLocalizer["Organization"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div id=\"organizationSelection\"></div>\r\n                                </div>\r\n                                <div class=\"mb-3\">\r\n                                    <label>");
#nullable restore
#line 57 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                                      Write(SharedLocalizer["Url API"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                    <div id=""urlApi""></div>
                                </div>
                                <div class=""mb-3"">
                                    <div id=""published""></div>
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            var treeView;

            var syncTreeViewSelection = function(treeView, value){
                if (!value) {
                    treeView.unselectAll();
                    return;
                }

                value.forEach(function(key){
                    treeView.selectItem(key);
                });

                if (value !== undefined) {
                    let catId = document.getElementById('CategoriesId');
                    while (catId.hasChildNodes()) {
                        catId.removeChild(catId.lastChild);
                    }
                    for (i = 0; i < value.length; i++) {
                        console.log(value[i]);
                        var input = document.createElement(""input"");
                        input.type = ""hidden"";
                        input.name = ""CategoriesId["" + i + ""]"";
                        input.value = value[i];
                        catId.appendChild(input);
");
                WriteLiteral(@"                    }
                }
            };

            var getSelectedItemsKeys = function(items) {
                var result = [];

                items.forEach(function (item) {
                    if(item.selected) {
                        result.push(item.key);
                    }
                    if(item.items.length) {
                        result = result.concat(getSelectedItemsKeys(item.items));
                    }
                });
                return result;
            };

            var arrCategories = ");
#nullable restore
#line 123 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                           Write(Html.Raw(Json.Serialize(Model.CategoriesId)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\r\n            $(\"#treeBox\").dxDropDownBox({\r\n                value: ");
#nullable restore
#line 126 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                  Write(Html.Raw(Json.Serialize(Model.CategoriesId)));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                valueExpr: \"id\",\r\n                displayExpr: \"name\",\r\n                placeholder: \'");
#nullable restore
#line 129 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                         Write(SharedLocalizer["Select categories"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                showClearButton: true,\r\n                dataSource: new DevExpress.data.DataSource({\r\n                    store: new DevExpress.data.AspNet.createStore({\r\n                        key: \"id\",\r\n                        loadUrl: `");
#nullable restore
#line 134 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                             Write(API.GetAllCategories);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                        loadMode: ""raw"",
                        onBeforeSend: function (method, ajaxOptions) {
                            ajaxOptions.xhrFields = { withCredentials: true };
                        }
                    }),
                    paginate: true,
                    pageSize:30
                }),
                contentTemplate: function(e){
                    var value = e.component.option(""value""),
                    $treeView = $(""<div>"").dxTreeView({
                        dataSource: e.component.option(""dataSource""),
                        dataStructure: ""plain"",
                        keyExpr: ""id"",
                        parentIdExpr: ""parentCategoryId"",
                        selectionMode: ""multiple"",
                        displayExpr: ""name"",
                        selectByClick: true,
                        onContentReady: function(args){
                            syncTreeViewSelection(args.component, value);
                      ");
                WriteLiteral(@"  },
                        selectNodesRecursive: false,
                        showCheckBoxesMode: ""normal"",
                        onItemSelectionChanged: function(args){
                            var nodes = args.component.getNodes(),
                                value = getSelectedItemsKeys(nodes);

                            e.component.option(""value"", value);
                        }
                    });

                    treeView = $treeView.dxTreeView(""instance"");

                    e.component.on(""valueChanged"", function(args){
                        var value = args.value;
                        syncTreeViewSelection(treeView, value);
                    });

                    return $treeView;
                }
            }).dxValidator({
                validationRules: [{
                    type: ""required"",
                    message: '");
#nullable restore
#line 178 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                         Write(SharedLocalizer["Select categories"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n\r\n            $(\"#name\").dxTextBox({\r\n                showClearButton: true,\r\n                name: \'Name\',\r\n                value: ");
#nullable restore
#line 185 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                  Write(Json.Serialize(Model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 189 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                         Write(SharedLocalizer["Enter name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                }]
            }).dxTextBox(""instance"");

            $(""#organizationSelection"").dxSelectBox({
                dataSource: new DevExpress.data.DataSource({
                    store: new DevExpress.data.AspNet.createStore({
                        key: ""id"",
                        loadUrl: `");
#nullable restore
#line 197 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                             Write(API.GetAllOrganizations);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                        loadMode: ""raw"",
                        onBeforeSend: function (method, ajaxOptions) {
                            ajaxOptions.xhrFields = { withCredentials: true };
                        }
                    }),
                    paginate: true,
                    pageSize:30
                }),
                displayExpr: ""name"",
                valueExpr: ""id"",
                name: 'OrganizationId',
                searchEnabled: true,
                value: ");
#nullable restore
#line 210 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                  Write(Html.Raw(Json.Serialize(Model.OrganizationId)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 214 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                         Write(SharedLocalizer["Choose organization"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n\r\n            $(\"#urlApi\").dxTextBox({\r\n                vshowClearButton: true,\r\n                name: \'UrlApi\',\r\n                value: ");
#nullable restore
#line 221 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                  Write(Json.Serialize(Model.UrlApi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 225 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                         Write(SharedLocalizer["Enter url api"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            }).dxTextBox(\"instance\");\r\n\r\n            $(\"#button\").dxButton({\r\n                text: \'");
#nullable restore
#line 230 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\Organization\EditOrganizationApi.cshtml"
                  Write(SharedLocalizer["Save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                type: \"success\",\r\n                useSubmitBehavior: true,\r\n            });\r\n            $(\"#summary\").dxValidationSummary({});\r\n\r\n        });\r\n\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Compare.BLL.DTOs.Organization.EditOrganizationApiDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
