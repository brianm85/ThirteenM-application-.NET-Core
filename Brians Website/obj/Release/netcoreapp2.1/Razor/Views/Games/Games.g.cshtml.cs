#pragma checksum "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Games\Games.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce55afc087a4503f3f01a843ec344d1585979336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Games), @"mvc.1.0.view", @"/Views/Games/Games.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Games/Games.cshtml", typeof(AspNetCore.Views_Games_Games))]
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
#line 1 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\_ViewImports.cshtml"
using Brians_Website;

#line default
#line hidden
#line 2 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\_ViewImports.cshtml"
using Brians_Website.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce55afc087a4503f3f01a843ec344d1585979336", @"/Views/Games/Games.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fa6dc54be645cc22010954bb62d9325f200b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Games : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckAPIModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Games\Games.cshtml"
  
    ViewData["Title"] = "Games";
    ////Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(114, 39, true);
            WriteLiteral("\r\n<h2>Games - Under Construction</h2>\r\n");
            EndContext();
            BeginContext(327, 7, true);
            WriteLiteral("<button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 334, "\"", 404, 3);
            WriteAttributeValue("", 344, "location.href=\'", 344, 15, true);
#line 10 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Games\Games.cshtml"
WriteAttributeValue("", 359, Url.Action("DownloadCV", "GamesController"), 359, 44, false);

#line default
#line hidden
            WriteAttributeValue("", 403, "\'", 403, 1, true);
            EndWriteAttribute();
            BeginContext(405, 20, true);
            WriteLiteral(">Go</button>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckAPIModel> Html { get; private set; }
    }
}
#pragma warning restore 1591