#pragma checksum "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\ProductDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b6d76a31d1d410c3716bfbec845e6996accd92b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetail_Index), @"mvc.1.0.view", @"/Views/ProductDetail/Index.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\_ViewImports.cshtml"
using FrontToBackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\_ViewImports.cshtml"
using FrontToBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\_ViewImports.cshtml"
using FrontToBackEnd.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\_ViewImports.cshtml"
using FrontToBackEnd.ViewModels.Admin.SliderViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6d76a31d1d410c3716bfbec845e6996accd92b", @"/Views/ProductDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536e8a9ef0f086b2faacecf94783024d1815246b", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/owl.carousel.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/owl.theme.default.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/flipclock.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/productDetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\ProductDetail\Index.cshtml"
  
    ViewData["Title"] = "Product Detail";

#line default
#line hidden
#nullable disable
            DefineSection("style", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b6d76a31d1d410c3716bfbec845e6996accd92b5615", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b6d76a31d1d410c3716bfbec845e6996accd92b6794", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b6d76a31d1d410c3716bfbec845e6996accd92b7973", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b6d76a31d1d410c3716bfbec845e6996accd92b9152", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<main>
    <div class=""details"">
        <div class=""container proddetail"">
            <h3>All Natural Italian-Style Chicken Meatballs</h3>
            <div class=""reyting mb-5"">
                <div class=""from"">
                    <span>Brands: </span>
                    <span>Welch's</span>
                </div>
                <div class=""star"">
                    <i class=""fas fa-star active""></i>
                    <i class=""fas fa-star active""></i>
                    <i class=""fas fa-star active""></i>
                    <i class=""fas fa-star active""></i>
                    <i class=""fas fa-star""></i>
                    <span>1 REVIEW</span>
                </div>
                <div class=""barcod"">
                    <span>SKU:</span>
                    <span>ZUli07VOR</span>
                </div>

            </div>
            <div class=""row"">
                <div class=""col-4 mycarousel"">
                    <div id=""carouselExampleIndicators"" class=""carousel ");
            WriteLiteral(@"slide"" data-ride=""carousel"">
                        <ol class=""carousel-indicators pt-5"">
                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active"">
                                <img src=""./assets/img/product-image-62-768x691.jpg"" style=""width: 60px;""");
            BeginWriteAttribute("alt", " alt=\"", 1675, "\"", 1681, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </li>\r\n                            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"1\">\r\n                                <img src=\"./assets/img/product-image2-47-768x691.jpg\" style=\"width: 60px;\"");
            BeginWriteAttribute("alt", " alt=\"", 1919, "\"", 1925, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </li>\r\n                            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"2\">\r\n                                <img src=\"./assets/img/product-image3-35-768x691.jpg\" style=\"width: 60px;\"");
            BeginWriteAttribute("alt", " alt=\"", 2163, "\"", 2169, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </li>
                        </ol>
                        <div class=""carousel-in"">
                            <div class=""carousel-item active"">
                                <img class=""d-block w-100"" src=""./assets/img/product-image-62-768x691.jpg""
                                     alt=""First slide"">
                                <span>23%</span>
                                <span>RECOMMEND</span>
                            </div>
                            <div class=""carousel-item"">
                                <img class=""d-block w-100"" src=""./assets/img/product-image2-47-768x691.jpg""
                                     alt=""Second slide"">
                                <span>23%</span>
                                <span>RECOMMEND</span>
                            </div>
                            <div class=""carousel-item"">
                                <img class=""d-block w-100"" src=""./assets/img/product-image3-35-768x691.jpg""
 ");
            WriteLiteral(@"                                    alt=""Third slide"">
                                <span>23%</span>
                                <span>RECOMMEND</span>
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""col-8 prdetail"">
                    <div class=""row "">
                        <div class=""col-6 mx-5"">
                            <div class=""pr"">
                                <span>$9.35</span>
                                <span>$7.25</span>
                            </div>
                            <div class=""stock"">
                                <span>IN STOCK</span>
                            </div>
                            <div class=""aboutprod mt-3"">
                                <p>
                                    Vivamus adipiscing nisl ut dolor dignissim semper. Nulla luctus malesuada
                                    tincidunt.
                        ");
            WriteLiteral(@"            Class aptent taciti sociosqu ad litora torquent
                                </p>
                            </div>
                            <div class=""prodnum"">
                                <span>-</span>
                                <span>1</span>
                                <span>+</span>
                                <input type=""button"" value=""ADD TO CARD"">
                            </div>
                            <div class=""wish"">
                                <span> <i class=""fas fa-heart""></i>ADD TO WISHLIST</span>
                                <span> <i class=""fas fa-exchange-alt""></i></i>COMPARE</span>
                            </div>
                            <div class=""aboutprod mt-5"">
                                <ul>
                                    <li> <i class=""fas fa-check""></i>Type: Organic</li>
                                    <li><i class=""fas fa-check""></i>MFG: Jun 4.2021</li>
                                    <li");
            WriteLiteral(@"><i class=""fas fa-check""></i>LIFE: 30 days</li>
                                </ul>
                            </div>
                            <hr class=""mt-5"">
                            <p>Category: Meats & Seafood</p>
                            <p>Tags: chicken, natural, organic</p>
                            <div class=""social"">
                                <ul>
                                    <li><i class=""fab fa-facebook""></i></li>
                                    <li><i class=""fab fa-twitter""></i></li>
                                    <li><i class=""fab fa-pinterest""></i></li>
                                    <li><i class=""fab fa-linkedin""></i></li>
                                    <li><i class=""fab fa-reddit""></i></li>
                                    <li><i class=""fab fa-whatsapp""></i></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-4 covid"">
           ");
            WriteLiteral(@"                 <p>Covid-19 Info: We keep delivering.</p>
                            <ul>
                                <li><i class=""fas fa-truck""></i>Free Shipping apply to all orders over $100</li>
                                <li><i class=""fas fa-leaf""></i>Guranteed 100% Organic from natural farmas</li>
                                <li><i class=""fas fa-money-bill""></i>1 Day Returns if you change your mind</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""blog container mt-5"">
            <div class=""navmenu"">
                <ul>
                    <li class=""active"" data-id=""1"">DESCRIPTION</li>
                    <li data-id=""2"">ADDITIONAL INFORMATION</li>
                    <li data-id=""3"">REVIEWS (1)</li>
                </ul>
                <hr>
                <div data-id=""1"" class=""d-none activecontent"">
                    <p>
              ");
            WriteLiteral(@"          Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aspernatur obcaecati alias
                        eligendi vero sit reprehenderit explicabo, dolorem accusantium voluptates ex eaque nobis
                        laudantium, assumenda, aperiam tempore dolor quo odio ad deleniti? Totam praesentium
                        necessitatibus rerum, minus sunt adipisci voluptatibus, itaque quidem nihil, repellat
                        repudiandae quis consectetur aut. Officiis, doloribus quod.
                        Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aspernatur obcaecati alias
                        eligendi vero sit reprehenderit explicabo, dolorem accusantium voluptates ex eaque nobis
                        laudantium, assumenda, aperiam tempore dolor quo odio ad deleniti? Totam praesentium
                        necessitatibus rerum, minus sunt adipisci voluptatibus, itaque quidem nihil, repellat
                        repudiandae quis consectetur aut. Offic");
            WriteLiteral(@"iis, doloribus quod.
                    </p>
                </div>
                <div data-id=""2"" class=""d-none "">
                    <div class=""row"">
                        <div class=""col-6"" style=""border-right: 1px solid black;"">
                            Brands
                        </div>
                        <div class=""col-6"">
                            Welch's
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""header container mb-3"" style=""width: 1200px; padding-top:40px ;padding-left: 0;;"">
            RELATED
            PRODUCTS
        </div>
        <div class=""prodrelate container"">

            <div class=""row"">
                <div class=""col-3"">
                    <div class=""card mycard"">
                        <img class="" card-img-top"" src=""https://klbtheme.com/bacola/wp-content/uploads/2021/04/product-image-48-346x310.jpg""
                             alt=""Card ima");
            WriteLiteral(@"ge cap"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Encore Seafoods Stuffed Alaskan Salmon</h5>
                            <span class=""stock"">IN STOCK</span>
                            <div class=""rateing"">
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star""></i>
                            </div>
                            <div class=""price mt-3"">
                                <span class=""oldprice"">$32.49</span>
                                <span class=""newprice mx-2"">$27.49</span>
                            </div>
                            <a href=""#"" class=""btn btn-primary mt-5"">Add to card</a>
                        </div>
   ");
            WriteLiteral(@"                     <div class=""percent"">16%</div>
                        <div class=""zoom""><i class=""fas fa-expand-arrows-alt""></i></div>
                        <div class=""heart""><i class=""far fa-heart""></i></div>
                    </div>
                </div>
                <div class=""col-3"">
                    <div class=""card mycard"">
                        <img class="" card-img-top"" src=""https://klbtheme.com/bacola/wp-content/uploads/2021/04/product-image-45-346x310.jpg""
                             alt=""Card image cap"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Foster Farms Takeout Crispy Classic Buffalo Wings</h5>
                            <span class=""stock"">IN STOCK</span>
                            <div class=""rateing"">
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-s");
            WriteLiteral(@"tar activerateing""></i>
                                <i class=""fas fa-star ""></i>
                                <i class=""fas fa-star""></i>
                            </div>
                            <div class=""price mt-3"">
                                <span class=""oldprice"">$57.25</span>
                                <span class=""newprice mx-2"">$49.25</span>
                            </div>
                            <a href=""#"" class=""btn btn-primary mt-5"">Add to card</a>
                        </div>
                        <div class=""percent"">26%</div>
                        <div class=""zoom""><i class=""fas fa-expand-arrows-alt""></i></div>
                        <div class=""heart""><i class=""far fa-heart""></i></div>
                    </div>
                </div>
                <div class=""col-3"">
                    <div class=""card mycard"">
                        <img class="" card-img-top"" src=""https://klbtheme.com/bacola/wp-content/uploads/2021/04/product-image-1");
            WriteLiteral(@"0-346x310.jpg""
                             alt=""Card image cap"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Tomatoes on the Vine</h5>
                            <span class=""stock"">IN STOCK</span>
                            <div class=""rateing"">
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                            </div>
                            <div class=""price mt-3"">
                                <span class=""oldprice"">$1.08</span>
                                <span class=""newprice mx-2"">$4.32</span>
                            </div>
                            <a href=""#"" class=""btn btn-primary mt-5"">");
            WriteLiteral(@"Add to card</a>
                        </div>
                        <div class=""percent"">19%</div>
                        <div class=""zoom""><i class=""fas fa-expand-arrows-alt""></i></div>
                        <div class=""heart""><i class=""far fa-heart""></i></div>
                    </div>
                </div>
                <div class=""col-3"">
                    <div class=""card mycard"">
                        <img class="" card-img-top"" src=""https://klbtheme.com/bacola/wp-content/uploads/2021/04/product-image-31-346x310.jpg""
                             alt=""Card image cap"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Organic 100% Grassfed 85_15 Ground Beef</h5>
                            <span class=""stock"">IN STOCK</span>
                            <div class=""rateing"">
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
        ");
            WriteLiteral(@"                        <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star""></i>
                            </div>
                            <div class=""price mt-3"">
                                <span class=""oldprice"">$7.00</span>
                                <span class=""newprice mx-2"">$5.99</span>
                            </div>
                            <a href=""#"" class=""btn btn-primary mt-5"">Add to card</a>
                        </div>
                        <div class=""percent"">13%</div>
                        <div class=""zoom""><i class=""fas fa-expand-arrows-alt""></i></div>
                        <div class=""heart""><i class=""far fa-heart""></i></div>
                    </div>
                </div>



            </div>
        </div>
        <div class=""header container mb-3"" style=""width: 1200px; padding-top:40px ;padding-left: 0;;"">
           ");
            WriteLiteral(@" RECENTLY
            VIEWED PRODUCTS
        </div>
        <div class=""prodrelate container "">

            <div class=""row"">
                <div class=""col-3"">
                    <div class=""card mycard"">
                        <img class="" card-img-top"" src=""./assets/img/product-image-62-346x310.jpg""
                             alt=""Card image cap"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">All Natural Italian-Style Chicken Meatballs</h5>
                            <span class=""stock"">IN STOCK</span>
                            <div class=""rateing"">
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star""></i>
                           ");
            WriteLiteral(@" </div>
                            <div class=""price mt-3"">
                                <span class=""oldprice"">$39.00</span>
                                <span class=""newprice mx-2"">$29.00</span>
                            </div>
                            <a href=""#"" class=""btn btn-primary mt-5"">Add to card</a>
                        </div>
                        <div class=""percent"">26%</div>
                        <div class=""zoom""><i class=""fas fa-expand-arrows-alt""></i></div>
                        <div class=""heart""><i class=""far fa-heart""></i></div>
                    </div>
                </div>
                <div class=""col-3"">
                    <div class=""card mycard"">
                        <img class="" card-img-top"" src=""https://klbtheme.com/bacola/wp-content/uploads/2021/04/product-image-59-346x310.jpg""
                             alt=""Card image cap"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Blue Di");
            WriteLiteral(@"amond Almonds Lightly Salted</h5>
                            <span class=""stock"">IN STOCK</span>
                            <div class=""rateing"">
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star ""></i>
                                <i class=""fas fa-star""></i>
                            </div>
                            <div class=""price mt-3"">
                                <span class=""oldprice"">$11.68</span>
                                <span class=""newprice mx-2"">$10.58</span>
                            </div>
                            <a href=""#"" class=""btn btn-primary mt-5"">Add to card</a>
                        </div>
                        <div class=""percent"">13%</div>
                        <div class=""zoom""><i class=""fas fa-expand-arrows-alt""></");
            WriteLiteral(@"i></div>
                        <div class=""heart""><i class=""far fa-heart""></i></div>
                    </div>
                </div>
                <div class=""col-3"">
                    <div class=""card mycard"">
                        <img class="" card-img-top"" src=""./assets/img/product-image-4-346x310 (1).jpg""
                             alt=""Card image cap"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Warrior Blend Organic</h5>
                            <span class=""stock"">IN STOCK</span>
                            <div class=""rateing"">
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                                <i class=""fas fa-star activerateing""></i>
                         ");
            WriteLiteral(@"   </div>
                            <div class=""price mt-3"">
                                <span class=""oldprice"">$33.00</span>
                                <span class=""newprice mx-2"">$25.00</span>
                            </div>
                            <a href=""#"" class=""btn btn-primary mt-5"">Add to card</a>
                        </div>
                        <div class=""percent"">26%</div>
                        <div class=""zoom""><i class=""fas fa-expand-arrows-alt""></i></div>
                        <div class=""heart""><i class=""far fa-heart""></i></div>
                    </div>
                </div>




            </div>
        </div>
    </div>

</main>");
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
