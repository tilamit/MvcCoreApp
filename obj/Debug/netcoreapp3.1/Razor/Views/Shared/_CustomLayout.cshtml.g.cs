#pragma checksum "C:\Users\AT\source\repos\OurCoreMvcApp\OurCoreMvcApp\Views\Shared\_CustomLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd419446e7f753bf6f89c892a985070018ec6900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CustomLayout), @"mvc.1.0.view", @"/Views/Shared/_CustomLayout.cshtml")]
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
#line 1 "C:\Users\AT\source\repos\OurCoreMvcApp\OurCoreMvcApp\Views\_ViewImports.cshtml"
using OurCoreMvcApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AT\source\repos\OurCoreMvcApp\OurCoreMvcApp\Views\_ViewImports.cshtml"
using OurCoreMvcApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd419446e7f753bf6f89c892a985070018ec6900", @"/Views/Shared/_CustomLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"123e06bff8432047bd9aa62705a6a087e15150b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CustomLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!-- Content Body -->\r\n<div class=\"content\">\r\n    ");
#nullable restore
#line 10 "C:\Users\AT\source\repos\OurCoreMvcApp\OurCoreMvcApp\Views\Shared\_CustomLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div style=\"background-color:rebeccapurple; color:antiquewhite; font-weight:bold\">\r\n    ");
#nullable restore
#line 14 "C:\Users\AT\source\repos\OurCoreMvcApp\OurCoreMvcApp\Views\Shared\_CustomLayout.cshtml"
Write(RenderSection("Note", false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\AT\source\repos\OurCoreMvcApp\OurCoreMvcApp\Views\Shared\_CustomLayout.cshtml"
Write(RenderSection("Footer", false));

#line default
#line hidden
#nullable disable
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
