#pragma checksum "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bf6d9ea558b7b24cf72fb1dac421ed7ad917147"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bf6d9ea558b7b24cf72fb1dac421ed7ad917147", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb5d84a3981ab67cb40e6ba34c6aa4e13ad35ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Views\Admin\Index.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""page-wrapper"">
    <div id=""page-inner"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h2>ADMIN DASHBOARD</h2>
            </div>
        </div>
        <!-- /. ROW  -->
        <hr />
        <div class=""row"">
            <div class=""col-lg-12 "">
                <div class=""alert alert-info"">
                    <strong>Welcome Jhon Doe ! </strong> You Have No pending Task For Today.
                </div>

            </div>
        </div>
        <!-- /. ROW  -->
        <div class=""row text-center pad-top"">
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf6d9ea558b7b24cf72fb1dac421ed7ad9171474627", async() => {
                WriteLiteral("\r\n                        <i class=\"fa fa-circle-o-notch fa-5x\"></i>\r\n                        <h4>Check Data</h4>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>


            </div>

            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-envelope-o fa-5x""></i>
                        <h4>Mail Box</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-lightbulb-o fa-5x""></i>
                        <h4>New Issues</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-users fa-5x""></i>
                        <h4>See Users</h4>
                    </a>
                </div>


      ");
            WriteLiteral(@"      </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-key fa-5x""></i>
                        <h4>Admin </h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-comments-o fa-5x""></i>
                        <h4>Support</h4>
                    </a>
                </div>


            </div>
        </div>
        <!-- /. ROW  -->
        <div class=""row text-center pad-top"">

            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-clipboard fa-5x""></i>
                        <h4>All Docs</h4>
                 ");
            WriteLiteral(@"   </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-gear fa-5x""></i>
                        <h4>Settings</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-wechat fa-5x""></i>
                        <h4>Live Talk</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-bell-o fa-5x""></i>
                        <h4>Notifications </h4>
                    </a>
                </div>


       ");
            WriteLiteral(@"     </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-rocket fa-5x""></i>
                        <h4>Launch</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-user fa-5x""></i>
                        <h4>Register User</h4>
                    </a>
                </div>


            </div>
        </div>
        <!-- /. ROW  -->
        <div class=""row text-center pad-top"">


            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-envelope-o fa-5x""></i>
                        <h4>Mail Box</h4>
            ");
            WriteLiteral(@"        </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-lightbulb-o fa-5x""></i>
                        <h4>New Issues</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-users fa-5x""></i>
                        <h4>See Users</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-key fa-5x""></i>
                        <h4>Admin </h4>
                    </a>
                </div>


     ");
            WriteLiteral(@"       </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""#"">
                        <i class=""fa fa-comments-o fa-5x""></i>
                        <h4>Support</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-circle-o-notch fa-5x""></i>
                        <h4>Check Data</h4>
                    </a>
                </div>


            </div>
        </div>
        <!-- /. ROW  -->
        <div class=""row text-center pad-top"">
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-rocket fa-5x""></i>
                        <h4>Launch</h4>
                 ");
            WriteLiteral(@"   </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-clipboard fa-5x""></i>
                        <h4>All Docs</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-gear fa-5x""></i>
                        <h4>Settings</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-wechat fa-5x""></i>
                        <h4>Live Talk</h4>
                    </a>
                </div>


          ");
            WriteLiteral(@"  </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-bell-o fa-5x""></i>
                        <h4>Notifications </h4>
                    </a>
                </div>


            </div>

            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-user fa-5x""></i>
                        <h4>Register User</h4>
                    </a>
                </div>


            </div>
        </div>
        <!-- /. ROW  -->
        <div class=""row text-center pad-top"">



            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-lightbulb-o fa-5x""></i>
                        <h4>New Issues</h4>
");
            WriteLiteral(@"                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-users fa-5x""></i>
                        <h4>See Users</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-key fa-5x""></i>
                        <h4>Admin </h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-comments-o fa-5x""></i>
                        <h4>Support</h4>
                    </a>
                </div>
");
            WriteLiteral(@"

            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-circle-o-notch fa-5x""></i>
                        <h4>Check Data</h4>
                    </a>
                </div>


            </div>
            <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-6"">
                <div class=""div-square"">
                    <a href=""blank.html"">
                        <i class=""fa fa-envelope-o fa-5x""></i>
                        <h4>Mail Box</h4>
                    </a>
                </div>


            </div>
        </div>
        <!-- /. ROW  -->
        <div class=""row"">
            <div class=""col-lg-12 "">
                <br />
                <div class=""alert alert-danger"">
                    <strong>Want More Icons Free ? </strong> Checkout fontawesome website and use any icon <a target=""_blank"" href=""http://fortawesome.githu");
            WriteLiteral("b.io/Font-Awesome/icons/\">Click Here</a>.\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <!-- /. ROW  -->\r\n    </div>\r\n    <!-- /. PAGE INNER  -->\r\n</div>\r\n<!-- /. PAGE WRAPPER  -->");
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
