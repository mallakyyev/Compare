#pragma checksum "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53ebf34284519c3b6364dd03e2c4f69ee880fa46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_ProductComments_Index), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ProductComments/Index.cshtml")]
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
#line 1 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\_ViewImports.cshtml"
using Compare.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\_ViewImports.cshtml"
using Compare.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Compare.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using Compare.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
using Compare.Utilits;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
using Compare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ebf34284519c3b6364dd03e2c4f69ee880fa46", @"/Areas/Identity/Pages/Account/Manage/ProductComments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b53858b0787f3e38efde1b74c2c3ad88a551001", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42339f5877464f17edb75208b8799df17ac446d0", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c980a5358362bd01ff417212aca72f1a29a074", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ProductComments_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Product comments"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 12 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<hr />
<div class=""row"">
    <div class=""col-md-12"">
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
#line 28 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
                  Write(API.GetAllProductCommentsByUser);

#line default
#line hidden
#nullable disable
                WriteLiteral("`;\r\n            let deleteComment = `");
#nullable restore
#line 29 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
                            Write(API.ProductCommentApi);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;

            $(""#gridContainer"").dxDataGrid({
                dataSource: new DevExpress.data.DataSource({
                    store: new DevExpress.data.AspNet.createStore({
                        key: ""id"",
                        loadUrl: url,
                        insertUrl: '',
                        updateUrl: '',
                        deleteUrl: deleteComment,
                        onBeforeSend: function (method, ajaxOptions) {
                            ajaxOptions.xhrFields = { withCredentials: true };
                        }
                    }),
                    paginate: true,
                    pageSize: 100
                }),
                onInitNewRow: function(e) {
                    var url = `./ProductComments/Create`
                    window.location = url;
                },
                selection: {
                    mode: ""multiple""
                },
                ""export"": {
                    enabled: true,
                  ");
                WriteLiteral(@"  fileName: ""ProductComments"",
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
                    allowAdding: false
                },
                headerFilter: {
                    visible: true
                },
                wordWrapEnabled: true,
                showColumnLines: true,
            ");
                WriteLiteral(@"    showRowLines: true,
                rowAlternationEnabled: true,
                showBorders: true,
                searchPanel: {
                    visible: true
                },
                stateStoring: {
                    enabled: true,
                    type: ""localStorage"",
                    storageKey: ""productCommentsIdentity""
                },
                columns: [
                    {
                        caption: '");
#nullable restore
#line 97 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
                             Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"name\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 102 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
                             Write(SharedLocalizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"description\",\r\n                        allowHeaderFiltering: false,\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 107 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
                             Write(SharedLocalizer["Publicate date"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"publicateDate\",\r\n                        dataType: \"datetime\",\r\n                        allowHeaderFiltering: false,\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 113 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
                             Write(SharedLocalizer["Status"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataField: ""isPublish"",
                        width: ""130"",
                        allowHeaderFiltering: false
                    },
                   {
                        type: ""buttons"",
                        GetAllOrganizationProductsidth: 110,
                        buttons: [
                            {
                                hint: '");
#nullable restore
#line 123 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
                                  Write(SharedLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                                icon: ""edit"",
                                visible: function (e) {
                                    return (e.row.data.isPublish == false);
                                },
                                onClick: function (e) {
                                    var idString = e.row.data.id;
                                    var url = `");
#nullable restore
#line 130 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Areas\Identity\Pages\Account\Manage\ProductComments\Index.cshtml"
                                          Write(Url.Page("/Account/Manage/ProductComments/Edit", new { Area = "Identity" }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Identity_Pages_Account_Manage_ProductComments_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Manage_ProductComments_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Manage_ProductComments_Index>)PageContext?.ViewData;
        public Areas_Identity_Pages_Account_Manage_ProductComments_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
