#pragma checksum "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_TravelApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a0a07da78ece0cbcf838dc6cdba6e42903fa238"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TravelApi), @"mvc.1.0.view", @"/Views/Shared/_TravelApi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TravelApi.cshtml", typeof(AspNetCore.Views_Shared__TravelApi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0a07da78ece0cbcf838dc6cdba6e42903fa238", @"/Views/Shared/_TravelApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fa6dc54be645cc22010954bb62d9325f200b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TravelApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckAPIModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 99, true);
            WriteLiteral("<div class=\"textbox\" id=\"TravelApi\">\r\n    <h3 class=\"centreheader\"><u>Travel</u></h3>\r\n    <br />\r\n");
            EndContext();
#line 5 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_TravelApi.cshtml"
     using (Html.BeginForm("TravelApi", "Api", FormMethod.Post))
    {
        

#line default
#line hidden
            BeginContext(203, 32, false);
#line 7 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_TravelApi.cshtml"
   Write(Html.LabelFor(m => m.BusStation));

#line default
#line hidden
            EndContext();
            BeginContext(246, 34, false);
#line 8 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_TravelApi.cshtml"
   Write(Html.TextBoxFor(m => m.BusStation));

#line default
#line hidden
            EndContext();
            BeginContext(293, 34, false);
#line 10 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_TravelApi.cshtml"
   Write(Html.LabelFor(m => m.TrainStation));

#line default
#line hidden
            EndContext();
            BeginContext(338, 36, false);
#line 11 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_TravelApi.cshtml"
   Write(Html.TextBoxFor(m => m.TrainStation));

#line default
#line hidden
            EndContext();
            BeginContext(378, 48, true);
            WriteLiteral("        <input type=\"submit\" value=\"Travel\" />\r\n");
            EndContext();
#line 14 "C:\Users\mitch\source\repos\Brians Website\Brians Website\Views\Shared\_TravelApi.cshtml"
    }

#line default
#line hidden
            BeginContext(433, 8, true);
            WriteLiteral("</div>\r\n");
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