#pragma checksum "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a19a05a99aa277192ec6c95feebc7cfdba5d717"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_ApplicationUser_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/ApplicationUser/Index.cshtml")]
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
#line 1 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
using Compare.Utilits;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
using Compare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a19a05a99aa277192ec6c95feebc7cfdba5d717", @"/Areas/Administrator/Views/ApplicationUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639ff3e55e44189a11449fae1f19354e5a7eab68", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_ApplicationUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Accounts"];
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"py-4\">\r\n    <div class=\"d-flex justify-content-between w-100 flex-wrap\">\r\n        <div class=\"mb-3 mb-lg-0\">\r\n            <h1 class=\"h4\">");
#nullable restore
#line 15 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                      Write(SharedLocalizer["Accounts"]);

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
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            let url = `");
#nullable restore
#line 34 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                  Write(API.GetAllUsers);

#line default
#line hidden
#nullable disable
                WriteLiteral("`;\r\n            let rUser = `");
#nullable restore
#line 35 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                    Write(API.RemoveUser);

#line default
#line hidden
#nullable disable
                WriteLiteral("`;\r\n            var returnUrl = \'");
#nullable restore
#line 36 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                        Write(Context.Request.Path);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                                             Write(Context.Request.QueryString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

            $(""#gridContainer"").dxDataGrid({
                dataSource: new DevExpress.data.DataSource({
                    store: new DevExpress.data.AspNet.createStore({
                        key: ""id"",
                        loadUrl: url,
                        insertUrl: '',
                        updateUrl: '',
                        deleteUrl: rUser,
                        onBeforeSend: function (method, ajaxOptions) {
                            ajaxOptions.xhrFields = { withCredentials: true };
                        }
                    }),
                    paginate: true,
                    pageSize: 100
                }),
                onInitNewRow: function(e) {
                    var url = `");
#nullable restore
#line 54 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                          Write(Url.Action("Create", "ApplicationUser", new { Area = "Administrator" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;
                    window.location = url;
                },
                selection: {
                    mode: ""multiple""
                },
                ""export"": {
                    enabled: true,
                    fileName: ""Users"",
                    allowExportSelectedData: true
                },
                filterPanel: {
                    visible: false
                },
                filterRow: { visible: false },
                remoteOperations: true,
                onRowUpdating: function (e) {
                    e.newData = Object.assign(e.oldData, e.newData)
                },
                scrolling: {
                    mode: ""virtual"",
                    rowRenderingMode: ""virtual""
                },
                paging: {
                    pageSize: 100
                },
                editing: {
                    useIcons: true,
                    allowUpdating: true,
                    allowDeleting: true,
           ");
                WriteLiteral(@"         allowAdding: true
                },
                headerFilter: {
                    visible: true
                },
                wordWrapEnabled: true,
                showColumnLines: true,
                showRowLines: true,
                rowAlternationEnabled: true,
                showBorders: true,
                searchPanel: {
                    visible: true
                },
                stateStoring: {
                    enabled: true,
                    type: ""localStorage"",
                    storageKey: ""usersAdmin""
                },
                columns: [
                    {
                        caption: '");
#nullable restore
#line 104 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                             Write(SharedLocalizer["Id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"id\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 109 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                             Write(SharedLocalizer["Full name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"fullName\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 114 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                             Write(SharedLocalizer["User name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"userName\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 119 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                             Write(SharedLocalizer["Email"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"email\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 124 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                             Write(SharedLocalizer["Organization name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataField: ""organizationName"",
                        allowHeaderFiltering: false
                    },
                   {
                        type: ""buttons"",
                        width: 110,
                        buttons: [
                            {
                                hint: '");
#nullable restore
#line 133 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                                  Write(SharedLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                icon: \"edit\",\r\n                                onClick: function (e) {\r\n                                    var idString = e.row.data.id;\r\n                                    var url = `");
#nullable restore
#line 137 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                                          Write(Url.Action("Edit", "ApplicationUser", new { Area = "Administrator" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("`;\r\n                                    window.location = url + \'?id=\' + idString;\r\n                                }\r\n                            },\r\n                            {\r\n                                hint: \'");
#nullable restore
#line 142 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                                  Write(SharedLocalizer["Change password"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                icon: \"key\",\r\n                                onClick: function (e) {\r\n                                    var idString = e.row.data.id;\r\n                                    var url = `");
#nullable restore
#line 146 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Administrator\Views\ApplicationUser\Index.cshtml"
                                          Write(Url.Action("ChangePassword", "ApplicationUser", new { Area = "Administrator" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;
                                    window.location = url + '?id=' + idString;
                                }
                            },
                            ""delete""
                        ]
                    }
                ]
            });

        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
