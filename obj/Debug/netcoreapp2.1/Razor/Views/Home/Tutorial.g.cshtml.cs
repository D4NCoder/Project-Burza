#pragma checksum "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Home\Tutorial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76f29839da1d0c918c51d15c3c3ec09662f44e80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tutorial), @"mvc.1.0.view", @"/Views/Home/Tutorial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Tutorial.cshtml", typeof(AspNetCore.Views_Home_Tutorial))]
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
#line 1 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\_ViewImports.cshtml"
using Project_Burza;

#line default
#line hidden
#line 2 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\_ViewImports.cshtml"
using Project_Burza.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f29839da1d0c918c51d15c3c3ec09662f44e80", @"/Views/Home/Tutorial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"128644f16229966027a4d98732e9d6e61a40b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tutorial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 409, true);
            WriteLiteral(@"<!-- start banner Area -->
<section class=""relative about-banner"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row d-flex align-items-center justify-content-center"">
            <div class=""about-content col-lg-12"">
                <h1 class=""text-white"">
                    Návod
                </h1>
                <p class=""text-white link-nav""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 409, "\"", 443, 1);
#line 10 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Home\Tutorial.cshtml"
WriteAttributeValue("", 416, Url.Action("Index","Home"), 416, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(444, 57, true);
            WriteLiteral(">Domů </a>  <span class=\"lnr lnr-arrow-right\"></span>  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 501, "\"", 538, 1);
#line 10 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Home\Tutorial.cshtml"
WriteAttributeValue("", 508, Url.Action("Tutorial","Home"), 508, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(539, 210, true);
            WriteLiteral("> Návod</a></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- End banner Area -->\r\n\r\n<section class=\"contact-page-area section-gap\">\r\n<div class=\"container\">\r\n<div></div>\r\n</div>\r\n</section>");
            EndContext();
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
