#pragma checksum "C:\Users\BONDO\Desktop\Tshilobo\tshilobo\tshilobo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09dda0929e3fb3152be18b9eac8a2b9cf0efff49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tshilobo.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(tshilobo.Pages.Pages_Index), null)]
namespace tshilobo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\BONDO\Desktop\Tshilobo\tshilobo\tshilobo\Pages\_ViewImports.cshtml"
using tshilobo;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09dda0929e3fb3152be18b9eac8a2b9cf0efff49", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db2a186eb2ad4c43a6a16f0815bab0eb2a7010bb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/users/user-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\BONDO\Desktop\Tshilobo\tshilobo\tshilobo\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 217, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <!-- Newsfeed Common Side Bar Left\r\n    ================================================= -->\r\n    <div class=\"col-md-3 static\">\r\n        <div class=\"profile-card\">            \r\n            ");
            EndContext();
            BeginContext(288, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "907e0ed69e8f46a88b63739bc117c6c7", async() => {
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
            BeginContext(359, 22667, true);
            WriteLiteral(@"
            <h5><a href=""timeline.html"" class=""text-white"">Sarah Cruiz</a></h5>
            <a href=""#"" class=""text-white""><i class=""ion ion-android-person-add""></i> 1,299 followers</a>
        </div><!--profile card ends-->
        <ul class=""nav-news-feed"">
            <li><i class=""icon ion-ios-paper""></i><div><a href=""newsfeed.html"">My Newsfeed</a></div></li>
            <li><i class=""icon ion-ios-people""></i><div><a href=""newsfeed-people-nearby.html"">People Nearby</a></div></li>
            <li><i class=""icon ion-ios-people-outline""></i><div><a href=""newsfeed-friends.html"">Friends</a></div></li>
            <li><i class=""icon ion-chatboxes""></i><div><a href=""newsfeed-messages.html"">Messages</a></div></li>
            <li><i class=""icon ion-images""></i><div><a href=""newsfeed-images.html"">Images</a></div></li>
            <li><i class=""icon ion-ios-videocam""></i><div><a href=""newsfeed-videos.html"">Videos</a></div></li>
        </ul><!--news-feed links ends-->
        <div id=""chat-block"">
   ");
            WriteLiteral(@"         <div class=""title"">Chat online</div>
            <ul class=""online-users list-inline"">
                <li><a href=""newsfeed-messages.html"" title=""Linda Lohan""><img src=""images/users/user-2.jpg"" alt=""user"" class=""img-responsive profile-photo"" /><span class=""online-dot""></span></a></li>
                <li><a href=""newsfeed-messages.html"" title=""Sophia Lee""><img src=""images/users/user-3.jpg"" alt=""user"" class=""img-responsive profile-photo"" /><span class=""online-dot""></span></a></li>
                <li><a href=""newsfeed-messages.html"" title=""John Doe""><img src=""images/users/user-4.jpg"" alt=""user"" class=""img-responsive profile-photo"" /><span class=""online-dot""></span></a></li>
                <li><a href=""newsfeed-messages.html"" title=""Alexis Clark""><img src=""images/users/user-5.jpg"" alt=""user"" class=""img-responsive profile-photo"" /><span class=""online-dot""></span></a></li>
                <li><a href=""newsfeed-messages.html"" title=""James Carter""><img src=""images/users/user-6.jpg"" alt=""user"" class");
            WriteLiteral(@"=""img-responsive profile-photo"" /><span class=""online-dot""></span></a></li>
                <li><a href=""newsfeed-messages.html"" title=""Robert Cook""><img src=""images/users/user-7.jpg"" alt=""user"" class=""img-responsive profile-photo"" /><span class=""online-dot""></span></a></li>
                <li><a href=""newsfeed-messages.html"" title=""Richard Bell""><img src=""images/users/user-8.jpg"" alt=""user"" class=""img-responsive profile-photo"" /><span class=""online-dot""></span></a></li>
                <li><a href=""newsfeed-messages.html"" title=""Anna Young""><img src=""images/users/user-9.jpg"" alt=""user"" class=""img-responsive profile-photo"" /><span class=""online-dot""></span></a></li>
                <li><a href=""newsfeed-messages.html"" title=""Julia Cox""><img src=""images/users/user-10.jpg"" alt=""user"" class=""img-responsive profile-photo"" /><span class=""online-dot""></span></a></li>
            </ul>
        </div><!--chat block ends-->
    </div>
    <div class=""col-md-7"">

        <!-- Post Create Box
        =======");
            WriteLiteral(@"========================================== -->
        <div class=""create-post"">
            <div class=""row"">
                <div class=""col-md-7 col-sm-7"">
                    <div class=""form-group"">
                        <img src=""images/users/user-1.jpg"" alt="""" class=""profile-photo-md"" />
                        <textarea name=""texts"" id=""exampleTextarea"" cols=""30"" rows=""1"" class=""form-control"" placeholder=""Write what you wish""></textarea>
                    </div>
                </div>
                <div class=""col-md-5 col-sm-5"">
                    <div class=""tools"">
                        <ul class=""publishing-tools list-inline"">
                            <li><a href=""#""><i class=""ion-compose""></i></a></li>
                            <li><a href=""#""><i class=""ion-images""></i></a></li>
                            <li><a href=""#""><i class=""ion-ios-videocam""></i></a></li>
                            <li><a href=""#""><i class=""ion-map""></i></a></li>
                        </ul");
            WriteLiteral(@">
                        <button class=""btn btn-primary pull-right"">Publish</button>
                    </div>
                </div>
            </div>
        </div><!-- Post Create Box End-->
        <!-- Post Content
        ================================================= -->
        <div class=""post-content"">
            <img src=""images/post-images/1.jpg"" alt=""post-image"" class=""img-responsive post-image"" />
            <div class=""post-container"">
                <img src=""images/users/user-5.jpg"" alt=""user"" class=""profile-photo-md pull-left"" />
                <div class=""post-detail"">
                    <div class=""user-info"">
                        <h5><a href=""timeline.html"" class=""profile-link"">Alexis Clark</a> <span class=""following"">following</span></h5>
                        <p class=""text-muted"">Published a photo about 3 mins ago</p>
                    </div>
                    <div class=""reaction"">
                        <a class=""btn text-green""><i class=""icon i");
            WriteLiteral(@"on-thumbsup""></i> 13</a>
                        <a class=""btn text-red""><i class=""fa fa-thumbs-down""></i> 0</a>
                    </div>
                    <div class=""line-divider""></div>
                    <div class=""post-text"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. <i class=""em em-anguished""></i> <i class=""em em-anguished""></i> <i class=""em em-anguished""></i></p>
                    </div>
                    <div class=""line-divider""></div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-11.jpg"" alt="""" class=""prof");
            WriteLiteral(@"ile-photo-sm"" />
                        <p><a href=""timeline.html"" class=""profile-link"">Diana </a><i class=""em em-laughing""></i> Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud </p>
                    </div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-4.jpg"" alt="""" class=""profile-photo-sm"" />
                        <p><a href=""timeline.html"" class=""profile-link"">John</a> Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud </p>
                    </div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-1.jpg"" alt="""" class=""profile-photo-sm"" />
                        <input type=""text"" class=""form-control"" placeholder=""Post a comment"">
                    </div>
           ");
            WriteLiteral(@"     </div>
            </div>
        </div>

        <!-- Post Content
        ================================================= -->
        <div class=""post-content"">
            <video class=""post-video"" controls> <source src=""videos/8.mp4"" type=""video/mp4""> </video>
            <div class=""post-container"">
                <img src=""images/users/user-3.jpg"" alt=""user"" class=""profile-photo-md pull-left"" />
                <div class=""post-detail"">
                    <div class=""user-info"">
                        <h5><a href=""timeline.html"" class=""profile-link"">Sophia Lee</a> <span class=""following"">following</span></h5>
                        <p class=""text-muted"">Updated her status about 33 mins ago</p>
                    </div>
                    <div class=""reaction"">
                        <a class=""btn text-green""><i class=""icon ion-thumbsup""></i> 75</a>
                        <a class=""btn text-red""><i class=""fa fa-thumbs-down""></i> 8</a>
                    </div>
         ");
            WriteLiteral(@"           <div class=""line-divider""></div>
                    <div class=""post-text"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
                    </div>
                    <div class=""line-divider""></div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-14.jpg"" alt="""" class=""profile-photo-sm"" />
                        <p><a href=""timeline.html"" class=""profile-link"">Olivia </a> Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. <i class=""em em-anguished""></i> Ut enim ad minim veniam, quis nostrud </p>
                    </div>
                    <div clas");
            WriteLiteral(@"s=""post-comment"">
                        <img src=""images/users/user-1.jpg"" alt="""" class=""profile-photo-sm"" />
                        <p><a href=""timeline.html"" class=""profile-link"">Sarah</a> Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.</p>
                    </div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-2.jpg"" alt="""" class=""profile-photo-sm"" />
                        <p><a href=""timeline.html"" class=""profile-link"">Linda</a> Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                    </div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-1.jpg"" alt="""" class=""profile-photo-sm"" />
             ");
            WriteLiteral(@"           <input type=""text"" class=""form-control"" placeholder=""Post a comment"">
                    </div>
                </div>
            </div>
        </div>

        <!-- Post Content
        ================================================= -->
        <div class=""post-content"">
            <div class=""post-container"">
                <img src=""images/users/user-2.jpg"" alt=""user"" class=""profile-photo-md pull-left"" />
                <div class=""post-detail"">
                    <div class=""user-info"">
                        <h5><a href=""timeline.html"" class=""profile-link"">Linda Lohan</a> <span class=""following"">following</span></h5>
                        <p class=""text-muted"">Published a photo about 1 hour ago</p>
                    </div>
                    <div class=""reaction"">
                        <a class=""btn text-green""><i class=""icon ion-thumbsup""></i> 23</a>
                        <a class=""btn text-red""><i class=""fa fa-thumbs-down""></i> 4</a>
                    ");
            WriteLiteral(@"</div>
                    <div class=""line-divider""></div>
                    <div class=""post-text"">
                        <p><i class=""em em-thumbsup""></i> <i class=""em em-thumbsup""></i> Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eu");
            WriteLiteral(@"m fugiat quo voluptas nulla pariatur?</p>
                    </div>
                    <div class=""line-divider""></div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-12.jpg"" alt="""" class=""profile-photo-sm"" />
                        <p><a href=""timeline.html"" class=""profile-link"">Cris </a> Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam <i class=""em em-muscle""></i></p>
                    </div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-1.jpg"" alt="""" class=""profile-photo-sm"" />
                        <input type=""text"" class=""form-control"" placeholder=""Post a comment"">
                    </div>
                </div>
            </div>
        </div>

        <!-- Post Content
        ================================================= -->
        <div class=""post-content"">
         ");
            WriteLiteral(@"   <img src=""images/post-images/2.jpg"" alt=""post-image"" class=""img-responsive post-image"" />
            <div class=""post-container"">
                <img src=""images/users/user-4.jpg"" alt=""user"" class=""profile-photo-md pull-left"" />
                <div class=""post-detail"">
                    <div class=""user-info"">
                        <h5><a href=""timeline.html"" class=""profile-link"">John Doe</a> <span class=""following"">following</span></h5>
                        <p class=""text-muted"">Published a photo about 2 hour ago</p>
                    </div>
                    <div class=""reaction"">
                        <a class=""btn text-green""><i class=""icon ion-thumbsup""></i> 39</a>
                        <a class=""btn text-red""><i class=""fa fa-thumbs-down""></i> 2</a>
                    </div>
                    <div class=""line-divider""></div>
                    <div class=""post-text"">
                        <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantiu");
            WriteLiteral(@"m doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt</p>
                    </div>
                    <div class=""line-divider""></div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-13.jpg"" alt="""" class=""profile-photo-sm"" />
                        <p><a href=""timeline.html"" class=""profile-link"">Brian </a>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. </p>
                    </div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-8.jpg"" alt="""" class=""profile-photo-sm"" />
                     ");
            WriteLiteral(@"   <p><a href=""timeline.html"" class=""profile-link"">Richard</a> Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. </p>
                    </div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-1.jpg"" alt="""" class=""profile-photo-sm"" />
                        <input type=""text"" class=""form-control"" placeholder=""Post a comment"">
                    </div>
                </div>
            </div>
        </div>

        <!-- Post Content
        ================================================= -->
        <div class=""post-content"">
            <div class=""google-maps"">
                <div id=""map"" class=""map""></div>
            </div>
            <div class=""post-container"">
                <img src=""images/users/user-3.jpg"" alt=""user"" class=""profile-photo-md pull-left"" />
                <div class=""post-detail"">
                    <div class=""user-info"">
         ");
            WriteLiteral(@"               <h5><a href=""timeline.html"" class=""profile-link"">Sophia Lee</a> <span class=""following"">following</span></h5>
                        <p class=""text-muted""><i class=""icon ion-ios-location""></i> Went to Niagara Falls today</p>
                    </div>
                    <div class=""reaction"">
                        <a class=""btn text-green""><i class=""icon ion-thumbsup""></i> 17</a>
                        <a class=""btn text-red""><i class=""fa fa-thumbs-down""></i> 0</a>
                    </div>
                    <div class=""line-divider""></div>
                    <div class=""post-text"">
                        <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio.</p>
               ");
            WriteLiteral(@"     </div>
                    <div class=""line-divider""></div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-1.jpg"" alt="""" class=""profile-photo-sm"" />
                        <p><a href=""timeline.html"" class=""profile-link"">Sarah </a>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. <i class=""em em-blush""></i> <i class=""em em-blush""></i> </p>
                    </div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-1.jpg"" alt="""" class=""profile-photo-sm"" />
                        <input type=""text"" class=""form-control"" placeholder=""Post a comment"">
                    </div>
                </div>
            </div>
        </div>

        <!-- Post Content
        ================================================= -->
        ");
            WriteLiteral(@"<div class=""post-content"">
            <img src=""images/post-images/11.jpg"" alt="""" class=""img-responsive post-image"" />
            <div class=""post-container"">
                <img src=""images/users/user-9.jpg"" alt=""user"" class=""profile-photo-md pull-left"" />
                <div class=""post-detail"">
                    <div class=""user-info"">
                        <h5><a href=""timeline.html"" class=""profile-link"">Anna Young</a> <span class=""following"">following</span></h5>
                        <p class=""text-muted"">Published a photo about 4 hour ago</p>
                    </div>
                    <div class=""reaction"">
                        <a class=""btn text-green""><i class=""icon ion-thumbsup""></i> 2</a>
                        <a class=""btn text-red""><i class=""fa fa-thumbs-down""></i> 0</a>
                    </div>
                    <div class=""line-divider""></div>
                    <div class=""post-text"">
                        <p>Sed ut perspiciatis unde omnis iste natus er");
            WriteLiteral(@"ror sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit.</p>
                    </div>
                    <div class=""line-divider""></div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-10.jpg"" alt="""" class=""profile-photo-sm"" />
                        <p><a href=""timeline.html"" class=""profile-link"">Julia </a>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.</p>
                    </div>
                    <div class=""post-comment"">
                        <img src=""images/users/user-1.jpg"" alt="""" class=""profile-photo");
            WriteLiteral(@"-sm"" />
                        <input type=""text"" class=""form-control"" placeholder=""Post a comment"">
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Newsfeed Common Side Bar Right
    ================================================= -->
    <div class=""col-md-2 static"">
        <div class=""suggestions"" id=""sticky-sidebar"">
            <h4 class=""grey"">Who to Follow</h4>
            <div class=""follow-user"">
                <img src=""images/users/user-11.jpg"" alt="""" class=""profile-photo-sm pull-left"" />
                <div>
                    <h5><a href=""timeline.html"">Diana Amber</a></h5>
                    <a href=""#"" class=""text-green"">Add friend</a>
                </div>
            </div>
            <div class=""follow-user"">
                <img src=""images/users/user-12.jpg"" alt="""" class=""profile-photo-sm pull-left"" />
                <div>
                    <h5><a href=""timeline.html"">Cris Haris</a></h5>
         ");
            WriteLiteral(@"           <a href=""#"" class=""text-green"">Add friend</a>
                </div>
            </div>
            <div class=""follow-user"">
                <img src=""images/users/user-13.jpg"" alt="""" class=""profile-photo-sm pull-left"" />
                <div>
                    <h5><a href=""timeline.html"">Brian Walton</a></h5>
                    <a href=""#"" class=""text-green"">Add friend</a>
                </div>
            </div>
            <div class=""follow-user"">
                <img src=""images/users/user-14.jpg"" alt="""" class=""profile-photo-sm pull-left"" />
                <div>
                    <h5><a href=""timeline.html"">Olivia Steward</a></h5>
                    <a href=""#"" class=""text-green"">Add friend</a>
                </div>
            </div>
            <div class=""follow-user"">
                <img src=""images/users/user-15.jpg"" alt="""" class=""profile-photo-sm pull-left"" />
                <div>
                    <h5><a href=""timeline.html"">Sophia Page</a></h5>
      ");
            WriteLiteral("              <a href=\"#\" class=\"text-green\">Add friend</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
