#pragma checksum "D:\BMax\Eleven\OAuth\Max.Core3_1.OAuth\Max.Core3_1.Auth2Demo\Views\Cookie\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ee577b0db2093467aece930419dcaa633f6be7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cookie_Info), @"mvc.1.0.view", @"/Views/Cookie/Info.cshtml")]
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
#line 1 "D:\BMax\Eleven\OAuth\Max.Core3_1.OAuth\Max.Core3_1.Auth2Demo\Views\_ViewImports.cshtml"
using Max.Core3_1.Auth2Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BMax\Eleven\OAuth\Max.Core3_1.OAuth\Max.Core3_1.Auth2Demo\Views\_ViewImports.cshtml"
using Max.Core3_1.Auth2Demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\BMax\Eleven\OAuth\Max.Core3_1.OAuth\Max.Core3_1.Auth2Demo\Views\Cookie\Info.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ee577b0db2093467aece930419dcaa633f6be7", @"/Views/Cookie/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c01f3b00a03572ab67b0be2bda82a33fd6b4d589", @"/Views/_ViewImports.cshtml")]
    public class Views_Cookie_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\BMax\Eleven\OAuth\Max.Core3_1.OAuth\Max.Core3_1.Auth2Demo\Views\Cookie\Info.cshtml"
  
    ViewData["Title"] = "Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Info 11111</h1>\r\n\r\n<h3>");
#nullable restore
#line 8 "D:\BMax\Eleven\OAuth\Max.Core3_1.OAuth\Max.Core3_1.Auth2Demo\Views\Cookie\Info.cshtml"
Write(base.Context.User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
        }
        #pragma warning restore 1998
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