#pragma checksum "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32116ce1ffafcc37535d88b5343989f05c7de484"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32116ce1ffafcc37535d88b5343989f05c7de484", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"128644f16229966027a4d98732e9d6e61a40b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 50, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"zxx\" class=\"no-js\">\r\n");
            EndContext();
            BeginContext(50, 1347, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69e10523a3964a6e89d0419ca3290d75", async() => {
                BeginContext(56, 1334, true);
                WriteLiteral(@"
    <!-- Mobile Specific Meta -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <!-- Favicon-->
    <link rel=""shortcut icon"" href=""img/fav.png"">
    <!-- Author Meta -->
    <meta name=""author"" content=""colorlib"">
    <!-- Meta Description -->
    <meta name=""description"" content="""">
    <!-- Meta Keyword -->
    <meta name=""keywords"" content="""">
    <!-- meta character set -->
    <meta charset=""UTF-8"">
    <!-- Site Title -->
    <title>Travel</title>

    <link href=""https://fonts.googleapis.com/css?family=Poppins:100,200,400,300,500,600,700"" rel=""stylesheet"">
    <!--
    CSS
    ============================================= -->
    <link rel=""stylesheet"" href=""/css/linearicons.css"">
    <link rel=""stylesheet"" href=""/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""/css/bootstrap.css"">
    <link rel=""stylesheet"" href=""/css/magnific-popup.css"">
    <link rel=""stylesheet"" href=""/css/jquery-ui.css"">
    <link rel=""styleshe");
                WriteLiteral(@"et"" href=""/css/nice-select.css"">
    <link rel=""stylesheet"" href=""/css/animate.min.css"">
    <link rel=""stylesheet"" href=""/css/owl.carousel.css"">
    <link rel=""stylesheet"" href=""/css/main.css"">
    <link rel=""stylesheet"" href=""/css/MyStyle.css"">
    <link rel=""stylesheet"" href=""/css/AccountStyle.css"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1397, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1399, 4770, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4a98434fbfd40a9a1920236a4530dd6", async() => {
                BeginContext(1405, 405, true);
                WriteLiteral(@"
    <header id=""header"">
        <div class=""header-top"">
            <div class=""container"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-6 col-sm-6 col-6 header-top-left"">
                        <ul>
                            <li><a href=""http://www.facebook.com/DanVyhlidal"" target=""_blank"">Facebook</a></li>
                            <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1810, "\"", 1846, 1);
#line 43 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1817, Url.Action("Contact","Home"), 1817, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1847, 323, true);
                WriteLiteral(@">Kontaktuj nás</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""container main-menu"">
            <div class=""row align-items-center justify-content-between d-flex"">
                <div id=""logo"">
                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2170, "\"", 2205, 1);
#line 52 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2177, Url.Action("Index", "Home"), 2177, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2206, 194, true);
                WriteLiteral("><img src=\"/img/logo.png\" alt=\"\" title=\"\" /></a>\r\n                </div>\r\n                <nav id=\"nav-menu-container\">\r\n                    <ul class=\"nav-menu\">\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2400, "\"", 2434, 1);
#line 56 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2407, Url.Action("Index","Home"), 2407, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2435, 46, true);
                WriteLiteral(">Domů</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2481, "\"", 2515, 1);
#line 57 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2488, Url.Action("About","Home"), 2488, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2516, 47, true);
                WriteLiteral(">O nás</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2563, "\"", 2597, 1);
#line 58 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2570, Url.Action("Trips","Trip"), 2570, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2598, 50, true);
                WriteLiteral(">Dovolené</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2648, "\"", 2688, 1);
#line 59 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2655, Url.Action("LawSecurity","Home"), 2655, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2689, 67, true);
                WriteLiteral(">Právní ochrana</a></li>\r\n                        <!--<li><a href=\"");
                EndContext();
                BeginContext(2757, 29, false);
#line 60 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
                                    Write(Url.Action("Tutorial","Home"));

#line default
#line hidden
                EndContext();
                BeginContext(2786, 51, true);
                WriteLiteral("\">Návod</a></li>-->\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2837, "\"", 2873, 1);
#line 61 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2844, Url.Action("Contact","Home"), 2844, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2874, 45, true);
                WriteLiteral(">Kontakt</a></li>\r\n\r\n                        ");
                EndContext();
                BeginContext(2920, 40, false);
#line 63 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
                   Write(await Html.PartialAsync("_LoginPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(2960, 152, true);
                WriteLiteral("\r\n                    </ul>\r\n                </nav><!-- #nav-menu-container -->\r\n            </div>\r\n        </div>\r\n    </header><!-- #header -->\r\n    ");
                EndContext();
                BeginContext(3113, 12, false);
#line 69 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3125, 2993, true);
                WriteLiteral(@"

    <!-- start footer Area -->
    <div class="" footer-area"">
        <div class=""container"">
            <div class=""row footer-bottom d-flex justify-content-between align-items-center"">
                <p class=""col-lg-8 col-sm-12 footer-text m-0"">
                    <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    Copyright &copy;
                    <script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class=""fa fa-heart-o"" aria-hidden=""true""></i> by <a href=""https://colorlib.com"" target=""_blank"">Colorlib</a>
                    <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                </p>
                <div class=""col-lg-4 col-sm-12 footer-social"">
                    <a href=""#""><i class=""fa fa-facebook""></i></a>
                    <a href=""#""><i class=""fa fa-twitter""></i></a>
                    <a href=""#""><i class=""fa fa-");
                WriteLiteral(@"dribbble""></i></a>
                    <a href=""#""><i class=""fa fa-behance""></i></a>
                </div>
            </div>
        </div>
    </div>

    <!-- End footer Area -->
    <script type=""text/javascript"" src=""/js/vendor/jquery-2.2.4.min.js""></script>
    <script type=""text/javascript"" src=""/js/popper.min.js""></script>
    <script type=""text/javascript"" src=""/js/vendor/bootstrap.min.js""></script>
    <script type=""text/javascript"" src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBhOdIF3Y9382fqJYt5I_sswSrEw5eihAA""></script>
    <script type=""text/javascript"" src=""/js/jquery-ui.js""></script>
    <script type=""text/javascript"" src=""/js/easing.min.js""></script>
    <script type=""text/javascript"" src=""/js/hoverIntent.js""></script>
    <script type=""text/javascript"" src=""/js/superfish.min.js""></script>
    <script type=""text/javascript"" src=""/js/jquery.ajaxchimp.min.js""></script>
    <script type=""text/javascript"" src=""/js/jquery.magnific-popup.min.js""></script>
    <script type");
                WriteLiteral(@"=""text/javascript"" src=""/js/jquery.nice-select.min.js""></script>
    <script type=""text/javascript"" src=""/js/owl.carousel.min.js""></script>
    <script type=""text/javascript"" src=""/js/mail-script.js""></script>
    <script type=""text/javascript"" src=""/js/main.js""></script>
    <script>
        $(function () {
            $('#upload').change(function () {
                var url = $(this).val();
                var ext = url.substring(url.lastIndexOf('.') + 1).toLowerCase();
                if (input.files && input.files[0] && (ext === ""gif"" || ext === ""png"" || ext === ""jpeg"" || ext === ""jpg"")) {
                    var reader = new FileReader();

                    reader.onload = function (e) {
                        $('#imgToUpload').attr('src', e.target.result);
                    }
                    reader.readAsDataURL(input.files[0]);
                }
            });

        });
    </script>

    ");
                EndContext();
                BeginContext(6119, 41, false);
#line 124 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(6160, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6169, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
