#pragma checksum "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Trip\Trips.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbcffaebccae3f231f932fc9fc8c1796daf21dcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trip_Trips), @"mvc.1.0.view", @"/Views/Trip/Trips.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Trip/Trips.cshtml", typeof(AspNetCore.Views_Trip_Trips))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbcffaebccae3f231f932fc9fc8c1796daf21dcb", @"/Views/Trip/Trips.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"128644f16229966027a4d98732e9d6e61a40b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Trip_Trips : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 410, true);
            WriteLiteral(@"<!-- start banner Area -->
<section class=""relative about-banner"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row d-flex align-items-center justify-content-center"">
            <div class=""about-content col-lg-12"">
                <h1 class=""text-white"">
                    Výlety
                </h1>
                <p class=""text-white link-nav""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 410, "\"", 445, 1);
#line 10 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Trip\Trips.cshtml"
WriteAttributeValue("", 417, Url.Action("Index", "Home"), 417, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(446, 57, true);
            WriteLiteral(">Domů </a>  <span class=\"lnr lnr-arrow-right\"></span>  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 503, "\"", 538, 1);
#line 10 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Trip\Trips.cshtml"
WriteAttributeValue("", 510, Url.Action("Trips", "Trip"), 510, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(539, 4464, true);
            WriteLiteral(@"""> Výlety</a></p>
            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->

<section>
    <div class=""text-center"">
        <a class=""genric-btn primary radius float-left mt-20"" href=""#"">Přidat vlastní příspěvek</a>
        <a class=""btn btn-warning circle LoginButton"" href=""#"">Přihlásit se</a>
        <a class=""genric-btn success radius float-right mt-20"" href=""#"">Přidat vlastní příspěvek</a>
    </div>


</section>

<!-- Start of a Login button (if the user is not logged in)

<section id=""ButtonSection"" style=""text-align: center;"">

</section>

<-- End of Login Button section -->

<section class=""mb-10"">
    <div class=""container"">
        <div class=""row"">
            <!-- Offers Grid -->
            <div class=""col-lg-11"" style=""margin-bottom:80px;"">

                <!-- Offers Sorting -->
                <div class=""offers_sorting_container"">
                    <ul class=""offers_sorting"">
                        <li>
                           ");
            WriteLiteral(@" <span class=""sorting_t
                                  ext"">cena</span>
                            <i class=""fa fa-chevron-down""></i>
                            <ul>
                                <li class=""sort_btn"" data-isotope-option='{ ""sortBy"": ""original-order"" }' data-parent="".price_sorting""><span>show all</span></li>
                                <li class=""sort_btn"" data-isotope-option='{ ""sortBy"": ""price"" }' data-parent="".price_sorting""><span>ascending</span></li>
                            </ul>
                        </li>
                        <li>
                            <span class=""sorting_text"">lokace</span>
                            <i class=""fa fa-chevron-down""></i>
                            <ul>
                                <li class=""sort_btn"" data-isotope-option='{ ""sortBy"": ""original-order"" }'><span>default</span></li>
                                <li class=""sort_btn"" data-isotope-option='{ ""sortBy"": ""name"" }'><span>alphabetical</span></li>
      ");
            WriteLiteral(@"                      </ul>
                        </li>
                        <li>
                            <span class=""sorting_text"">hodnocení</span>
                            <i class=""fa fa-chevron-down""></i>
                            <ul>
                                <li class=""filter_btn"" data-filter=""*""><span>show all</span></li>
                                <li class=""sort_btn"" data-isotope-option='{ ""sortBy"": ""stars"" }'><span>ascending</span></li>
                                <li class=""filter_btn"" data-filter="".rating_3""><span>3</span></li>
                                <li class=""filter_btn"" data-filter="".rating_4""><span>4</span></li>
                                <li class=""filter_btn"" data-filter="".rating_5""><span>5</span></li>
                            </ul>
                        </li>
                        <li class=""distance_item"">
                            <span class=""sorting_text"">počet dní</span>
                            <i class=""fa fa-che");
            WriteLiteral(@"vron-down""></i>
                            <ul>
                                <li class=""num_sorting_btn""><span>distance</span></li>
                                <li class=""num_sorting_btn""><span>distance</span></li>
                                <li class=""num_sorting_btn""><span>distance</span></li>
                            </ul>
                        </li>
                        <li>
                            <span class=""sorting_text"">datum</span>
                            <i class=""fa fa-chevron-down""></i>
                            <ul>
                                <li class=""num_sorting_btn""><span>review</span></li>
                                <li class=""num_sorting_btn""><span>review</span></li>
                                <li class=""num_sorting_btn""><span>review</span></li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>

            
            <div class=""col-lg-11 m");
            WriteLiteral(@"t-20"">
                <!-- Offers Item -->

                <div class=""offers_item rating_4 mb-20"">
                    <div class=""row"">
                        <div class=""col-lg-3 col-1680-4"">
                            <div class=""offers_image_container"">
                                <div class=""offers_image_background"" style=""background-image:url('");
            EndContext();
            BeginContext(5004, 32, false);
#line 102 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Trip\Trips.cshtml"
                                                                                             Write(Url.Content("/img/Krkonose.jpg"));

#line default
#line hidden
            EndContext();
            BeginContext(5036, 2625, true);
            WriteLiteral(@"'); max-height: 292px;""></div>
                                <div class=""offer_name text-md-center""><a href=""single_listing.html"">VÍCE ZDE</a></div>
                            </div>
                        </div>
                        <div class=""col-lg-8"">
                            <div class=""offers_content"">
                                <div class=""offers_price"">Chata v Krkonoších</div>
                                <div class=""rating_r rating_r_3 offers_rating"" data-rating=""3"">
                                    <i></i>
                                    <i></i>
                                    <i></i>
                                    <i></i>
                                    <i></i>
                                </div>
                                <p class=""offers_text"">Dobrý den, mé jméno je Milada Dvořáková a sháním náhradníka na 5 dní pro tuto nádhernou chatu v Krkonoších</p>
                                <div class=""offers_icons mb-15"">
                  ");
            WriteLiteral(@"                  <ul class="""">
                                        <li>Autor: <b style=""color: black"">Milada Dvořáková</b></li>
                                        <li>tel. číslo: <b style=""color: black"">+420 773 493 616</b></li>
                                        <li>Datum: <b style=""color: black"">12.3. 2018 - 17.3. 2018</b></li>
                                        <li>Lokace: <b style=""color: black"">Krkonoše, škraloupy</b></li>
                                    </ul>
                                </div>
                                <div class=""button book_button""><a href=""#"">Odkoupit<span></span><span></span><span></span></a></div>
                                <div class=""offer_reviews"">
                                    <div class=""offer_reviews_content"">
                                        <div class=""offer_reviews_title"">Cena</div>
                                        <div class=""offer_reviews_subtitle"">5 dní</div>
                                    </div");
            WriteLiteral(@">
                                    <div class=""offer_reviews_rating text-center"">33 600,-</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""offers_item rating_5"">
                    <div class=""row"">
                        <div class=""col-lg-3 col-1680-4"">
                            <div class=""offers_image_container"">
                                <div class=""offers_image_background"" style=""background-image:url('");
            EndContext();
            BeginContext(7662, 28, false);
#line 142 "C:\Users\Dan\source\repos\Project-Burza\Project-Burza\Views\Trip\Trips.cshtml"
                                                                                             Write(Url.Content("/img/Alps.jpg"));

#line default
#line hidden
            EndContext();
            BeginContext(7690, 2368, true);
            WriteLiteral(@"'); max-height: 292px;""></div>
                                <div class=""offer_name text-md-center""><a href=""single_listing.html"">VÍCE ZDE</a></div>
                            </div>
                        </div>
                        <div class=""col-lg-8"">
                            <div class=""offers_content"">
                                <div class=""offers_price"">Chata v Alpách</div>
                                <div class=""rating_r rating_r_5 offers_rating"" data-rating=""5"">
                                    <i></i>
                                    <i></i>
                                    <i></i>
                                    <i></i>
                                    <i></i>
                                </div>
                                <p class=""offers_text"">Dobrý den, mé jméno je Dan Skořápka a sháním náhradníka na 8 dní pro tuto nádhernou chatu v Alpách</p>
                                <div class=""offers_icons mb-15"">
                              ");
            WriteLiteral(@"      <ul class="""">
                                        <li>Autor: <b style=""color: black"">Daniel Skořápka</b></li>
                                        <li>tel. číslo: <b style=""color: black"">+420 773 486 958</b></li>
                                        <li>Datum: <b style=""color: black"">5.1. 2018 - 13.1. 2018</b></li>
                                        <li>Lokace: <b style=""color: black"">Alpy, Chata ""Pod Sněhem""</b></li>
                                    </ul>
                                </div>
                                <div class=""button book_button""><a href=""#"">Odkoupit<span></span><span></span><span></span></a></div>
                                <div class=""offer_reviews"">
                                    <div class=""offer_reviews_content"">
                                        <div class=""offer_reviews_title"">Cena</div>
                                        <div class=""offer_reviews_subtitle"">8 dní</div>
                                    </div>
      ");
            WriteLiteral(@"                              <div class=""offer_reviews_rating text-center"">50 600,-</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </div>
</section>
");
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
