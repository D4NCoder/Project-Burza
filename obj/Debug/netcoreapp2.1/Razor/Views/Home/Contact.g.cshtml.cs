#pragma checksum "/Users/dvyhlidal19/Documents/GitHub/Project-Burza/Views/Home/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb955771e5baf3c2e329f40adb8d1b3b91b27567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "/Users/dvyhlidal19/Documents/GitHub/Project-Burza/Views/_ViewImports.cshtml"
using Project_Burza;

#line default
#line hidden
#line 2 "/Users/dvyhlidal19/Documents/GitHub/Project-Burza/Views/_ViewImports.cshtml"
using Project_Burza.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb955771e5baf3c2e329f40adb8d1b3b91b27567", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aa640dd55cc97e7b1307929a8f86bd70c76bf2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-area contact-form text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2217, true);
            WriteLiteral(@"<!-- start banner Area -->
<section class=""relative about-banner"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row d-flex align-items-center justify-content-center"">
            <div class=""about-content col-lg-12"">
                <h1 class=""text-white"">
                    Kontaktuj nás
                </h1>
                <p class=""text-white link-nav""><a href=""index.html"">Domů </a>  <span class=""lnr lnr-arrow-right""></span>  <a href=""contact.html""> Kontakt</a></p>
            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->
<!-- Start contact-page Area -->
<section class=""contact-page-area section-gap"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 d-flex flex-column address-wrap"">
                <div class=""single-contact-address d-flex flex-row"">
                    <div class=""icon"">
                        <span class=""lnr lnr-coffee-cup ""></span>
                    </div>
                   ");
            WriteLiteral(@" <div class=""contact-details"">
                        <h5>Společnost která se o tebe postará</h5>
                        <p>Jsme ti k službám 24 hodin / 7 dní v týdnu </p>
                    </div>
                </div>

                <div class=""single-contact-address d-flex flex-row"">
                    <div class=""icon"">
                        <span class=""lnr lnr-thumbs-up""></span>
                    </div>
                    <div class=""contact-details"">
                        <h5>Faceboook</h5>
                        <p><a href=""http://www.facebook.com/DanVyhlidal97"" target=""_blank"">http://www.facebook.com/</a></p>
                    </div>
                </div>

                <div class=""single-contact-address d-flex flex-row"">
                    <div class=""icon"">
                        <span class=""lnr lnr-envelope""></span>
                    </div>
                    <div class=""contact-details"">
                        <h5>tripexchange.support@gmail.com</h5>
                    ");
            WriteLiteral("    <p>Neboj se nás kontaktovat přes e-mail!</p>\n                    </div>\n                </div>\n            </div>\n            <div class=\"col-lg-8\">\n                ");
            EndContext();
            BeginContext(2217, 1570, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89a55928ff7d4f24aac198c97923b3e5", async() => {
                BeginContext(2309, 1471, true);
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-lg-6 form-group"">
                            <input name=""name"" placeholder=""Zadej své jméno"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter your name'"" class=""common-input mb-20 form-control"" required="""" type=""text"">

                            <input name=""email"" placeholder=""Zadej svůj e-mail"" pattern=""[A-Za-z0-9._%+-]+[A-Za-z0-9.-]+\.[A-Za-z]{1,63}$"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter email address'"" class=""common-input mb-20 form-control"" required="""" type=""email"">

                            <input name=""subject"" placeholder=""Zadej předmět"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter subject'"" class=""common-input mb-20 form-control"" required="""" type=""text"">
                        </div>
                        <div class=""col-lg-6 form-group"">
                            <textarea class=""common-textarea form-control"" name=""message"" placeholder=""Zpráva""");
                WriteLiteral(@" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter Messege'"" required=""""></textarea>
                        </div>
                        <div class=""col-lg-12"">
                            <div class=""alert-msg"" style=""text-align: left;""></div>
                            <button class=""genric-btn primary"" style=""float: right;"">Odeslat zprávu</button>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3787, 88, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</section>\n<!-- End contact-page Area -->\n");
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
