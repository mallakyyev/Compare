#pragma checksum "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Home\Advertising.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e5c2b0b1dfd265177470d4e199bd98cde165a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Advertising), @"mvc.1.0.view", @"/Views/Home/Advertising.cshtml")]
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
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Home\Advertising.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e5c2b0b1dfd265177470d4e199bd98cde165a2", @"/Views/Home/Advertising.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639ff3e55e44189a11449fae1f19354e5a7eab68", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Advertising : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Compare.BLL.DTOs.Info.InformationListDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Home\Advertising.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Advertising"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Content -->\r\n<div id=\"content\">\r\n    <section class=\"skills padding-top-10\">\r\n        <div class=\"container\">\r\n            ");
#nullable restore
#line 14 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Home\Advertising.cshtml"
       Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Compare.BLL.DTOs.Info.InformationListDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591