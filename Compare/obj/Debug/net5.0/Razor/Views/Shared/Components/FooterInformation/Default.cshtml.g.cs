#pragma checksum "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Shared\Components\FooterInformation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a0a4869465522e11fac8d7d66d995d0212d7325"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FooterInformation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FooterInformation/Default.cshtml")]
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
#line 2 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Shared\Components\FooterInformation\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a0a4869465522e11fac8d7d66d995d0212d7325", @"/Views/Shared/Components/FooterInformation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639ff3e55e44189a11449fae1f19354e5a7eab68", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FooterInformation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Compare.BLL.DTOs.Info.InformationListDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 8 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Shared\Components\FooterInformation\Default.cshtml"
         if(Model != null){
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Shared\Components\FooterInformation\Default.cshtml"
       Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\allak\Source\Repos\Shamil-7\Compare\Compare\Compare\Views\Shared\Components\FooterInformation\Default.cshtml"
                                        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
