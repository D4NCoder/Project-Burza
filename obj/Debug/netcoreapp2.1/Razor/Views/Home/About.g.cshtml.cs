#pragma checksum "/Users/dvyhlidal19/Documents/GitHub/Project-Burza/Views/Home/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc072d2776032253a4a681706affc4bb2eb325e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc072d2776032253a4a681706affc4bb2eb325e7", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aa640dd55cc97e7b1307929a8f86bd70c76bf2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/New/Typing.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/New/Buying.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/New/Ad.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/facebook.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 400, true);
            WriteLiteral(@"<!-- start banner Area -->
<section class=""about-banner relative"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row d-flex align-items-center justify-content-center"">
            <div class=""about-content col-lg-12"">
                <h1 class=""text-white"">
                    O nás
                </h1>
                <p class=""text-white link-nav""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 400, "\"", 434, 1);
#line 10 "/Users/dvyhlidal19/Documents/GitHub/Project-Burza/Views/Home/About.cshtml"
WriteAttributeValue("", 407, Url.Action("Index","Home"), 407, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(435, 57, true);
            WriteLiteral(">Domů </a>  <span class=\"lnr lnr-arrow-right\"></span>  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 492, "\"", 526, 1);
#line 10 "/Users/dvyhlidal19/Documents/GitHub/Project-Burza/Views/Home/About.cshtml"
WriteAttributeValue("", 499, Url.Action("About","Home"), 499, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(527, 4073, true);
            WriteLiteral(@"> O nás</a></p>
            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->


<section class=""hlavni-sekce team"" id=""team"">
    <!--main-section team-start-->
    <div class=""container"">
        <div class=""team-leader-block clearfix"">
            <div class=""team-leader-box"">
                <div class=""team-leader wow fadeInDown delay-03s"">
                    <div class=""team-leader-shadow""><a href=""#""></a></div>
                    <img src=""/img/team-leader-pic1.png"" alt="""">
                    <ul>
                        <li><a href=""#"" class=""fa fa-dribbble""></a></li>
                        <li><a href=""#"" class=""fa-facebook""></a></li>
                    </ul>
                </div>
                <h3 class=""wow fadeInDown delay-03s"">Jana Červenková</h3>
                <span class=""wow fadeInDown delay-03s"">Zakladatelka nápadu</span>
            </div>
            <div class=""team-leader-box"">
                <div class=""team-leader  wow fadeInDown delay-06s"">
                ");
            WriteLiteral(@"    <div class=""team-leader-shadow""><a href=""#""></a></div>
                    <img src=""/img/team-leader-pic2.jpg"" alt="""">
                    <ul>
                        <li><a href=""#"" class=""fa-google-plus""></a></li>
                        <li><a href=""#"" class=""fa-facebook""></a></li>
                    </ul>
                </div>
                <h3 class=""wow fadeInDown delay-06s"">Dan Vyhlídal</h3>
                <span class=""wow fadeInDown delay-06s"">Hlavní vývojář</span>
            </div>
            <div class=""team-leader-box"">
                <div class=""team-leader wow fadeInDown delay-09s"">
                    <div class=""team-leader-shadow""><a href=""#""></a></div>
                    <img src=""/img/team-leader-pic3.png"" alt="""">
                    <ul>
                        <li><a href=""#"" class=""fa-google-plus""></a></li>
                        <li><a href=""#"" class=""fa-facebook""></a></li>
                    </ul>
                </div>
                <h3 class=""wow fadeInDown delay-09");
            WriteLiteral(@"s"">Jana Traplová</h3>
                <span class=""wow fadeInDown delay-09s"">Právnička</span> 
            </div>
        </div>
    </div>
</section><!--main-section team-end-->

<section>
    <div class=""whole-wrap"">
        <div class=""container"">
            <div class=""section-top-border"">
                <h2 class=""mb-30"">Kdo jsme ?</h2>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <blockquote class=""generic-blockquote"">
                            “Recently, the US Federal government banned online casinos from operating in America by making it illegal to transfer money to them through any US bank or payment system. As a result of this law, most of the popular online casino networks such as Party Gaming and PlayTech left the United States. Overnight, online casino players found themselves being chased by the Federal government. But, after a fortnight, the online casino industry came up with a solution and new online casinos started taking root. Th");
            WriteLiteral(@"ese began to operate under a different business umbrella, and by doing that, rendered the transfer of money to and from them legal. A major part of this was enlisting electronic banking systems that would accept this new clarification and start doing business with me. Listed in this article are the electronic banking”
                        </blockquote>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""price-area mt-50"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""menu-content pb-70 col-lg-9"">
                <div class=""title text-center"">
                    <h1 class=""mb-10 mt-20"">Služby které poskytujeme</h1>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 col-md-6"">
                <div class=""single-other-issue"">
                    <div class=""thumb"">
                        ");
            EndContext();
            BeginContext(4600, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbf4528a0eb448c9acb90f9611904167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4657, 514, true);
            WriteLiteral(@"
                    </div>
                    <a href=""#"">
                        <h4>Vlastní inzerát</h4>
                    </a>
                    <p>
                        Když si založíš vlastní účet, máš možnost napsat si vlastní inzerát a využít tak naší marketingové plochy.
                    </p>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6"">
                <div class=""single-other-issue"">
                    <div class=""thumb"">
                        ");
            EndContext();
            BeginContext(5171, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b49a13d9023484da4971d59a23da476", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5228, 505, true);
            WriteLiteral(@"
                    </div>
                    <a href=""#"">
                        <h4>Odkupovaní dovolených</h4>
                    </a>
                    <p>
                        Když si založíš vlastní účet, máš možnost zarezervovat, či odkoupit od inzerenta dovolenou.
                    </p>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6"">
                <div class=""single-other-issue"">
                    <div class=""thumb"">
                        ");
            EndContext();
            BeginContext(5733, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82da4de1d7364b70b5459bd29541eb4a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5786, 229, true);
            WriteLiteral("\n                    </div>\n                    <a href=\"#\">\n                        <h4>Reklamní plochu</h4>\n                    </a>\n                    <p>\n                        Pokud máte zájem o pronájem reklamní plochy <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6015, "\"", 6051, 1);
#line 125 "/Users/dvyhlidal19/Documents/GitHub/Project-Burza/Views/Home/About.cshtml"
WriteAttributeValue("", 6022, Url.Action("Contact","Home"), 6022, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6052, 245, true);
            WriteLiteral(">kontaktujte nás</a>\n                    </p>\n                </div>\n            </div>\n            <div class=\"col-lg-3 col-md-6\">\n                <div class=\"single-other-issue\">\n                    <div class=\"thumb\">\n                        ");
            EndContext();
            BeginContext(6297, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c7777b759ffd4fa382446ebc6497cc98", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6352, 963, true);
            WriteLiteral(@"
                    </div>
                    <a href=""#"">
                        <h4>Sociální sítě</h4>
                    </a>
                    <p>
                        Váš nově podaný inzerát vám rádi sdílneme na naší facebookové stránce. <a href=""http://www.facebook.com"">ZDE</a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End other-issue Area -->

<section id=""colorlib-subscribe"" class=""section-half contact-area "" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-md-offset-3 text-center colorlib-heading animate-box"">
                <h2>Zústantě s námi v kontaktu</h2>
                <p><i>Více se dozvíte kliknutím na níže uvedé tlačítko</i></p>
                <a class=""genric-btn primary circle"">Kontakt</a>
            </div>
        </div>
    </div>
</section>");
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
