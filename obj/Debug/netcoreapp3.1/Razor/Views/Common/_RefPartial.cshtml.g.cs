#pragma checksum "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Views\Common\_RefPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13fe1e17ceefcef49cbdec598304c51dbef75e5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common__RefPartial), @"mvc.1.0.view", @"/Views/Common/_RefPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13fe1e17ceefcef49cbdec598304c51dbef75e5c", @"/Views/Common/_RefPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb5d84a3981ab67cb40e6ba34c6aa4e13ad35ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Common__RefPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SharedFolder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!--<a from=");
#nullable restore
#line 3 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Views\Common\_RefPartial.cshtml"
       Write(Model.SharedPath);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to=");
#nullable restore
#line 3 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Views\Common\_RefPartial.cshtml"
                            Write(Model.Folder.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 3 "C:\Users\Y\source\repos\WebApplication8\WebApplication8\Views\Common\_RefPartial.cshtml"
                                               Write(Model.Folder.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SharedFolder> Html { get; private set; }
    }
}
#pragma warning restore 1591
