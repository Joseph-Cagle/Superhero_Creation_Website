#pragma checksum "C:\Users\Elgacson\source\repos\superHero\Views\superHero\thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea939b2bc9f8b6faa63bd9fa609373a73ba867b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_superHero_thanks), @"mvc.1.0.view", @"/Views/superHero/thanks.cshtml")]
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
#line 1 "C:\Users\Elgacson\source\repos\superHero\Views\_ViewImports.cshtml"
using superHero;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elgacson\source\repos\superHero\Views\_ViewImports.cshtml"
using superHero.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea939b2bc9f8b6faa63bd9fa609373a73ba867b6", @"/Views/superHero/thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1c2f541dbb524af75221be1d3f086e0ed70c99", @"/Views/_ViewImports.cshtml")]
    public class Views_superHero_thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<heroInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Elgacson\source\repos\superHero\Views\superHero\thanks.cshtml"
  
    ViewData["Title"] = "Thanks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    <h1>Thank you for taking the time to make a hero!</h1>\r\n   \r\n    <div></div>\r\n\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h2>Hero Name</h2>\r\n                <p> ");
#nullable restore
#line 19 "C:\Users\Elgacson\source\repos\superHero\Views\superHero\thanks.cshtml"
               Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </div>\r\n            <div class=\"col\">\r\n                <h2>Hero Origin</h2>\r\n                <p>");
#nullable restore
#line 23 "C:\Users\Elgacson\source\repos\superHero\Views\superHero\thanks.cshtml"
              Write(Model.origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col\">\r\n                <h2>Date Of Birth</h2>\r\n                <p> ");
#nullable restore
#line 27 "C:\Users\Elgacson\source\repos\superHero\Views\superHero\thanks.cshtml"
               Write(Model.dob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h2>First Power</h2>\r\n                <p> ");
#nullable restore
#line 33 "C:\Users\Elgacson\source\repos\superHero\Views\superHero\thanks.cshtml"
               Write(Model.power1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col\">\r\n                <h2>Second Power</h2>\r\n                <p> ");
#nullable restore
#line 37 "C:\Users\Elgacson\source\repos\superHero\Views\superHero\thanks.cshtml"
               Write(Model.power2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col\">\r\n                <h2>Weakness</h2>\r\n                <p> ");
#nullable restore
#line 41 "C:\Users\Elgacson\source\repos\superHero\Views\superHero\thanks.cshtml"
               Write(Model.weaknes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<heroInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591