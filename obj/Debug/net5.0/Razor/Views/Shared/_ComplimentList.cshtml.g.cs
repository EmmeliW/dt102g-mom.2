#pragma checksum "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\Shared\_ComplimentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67a91feb346b9c1f53445be5921e03bea1fc5672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MVC.Views.Shared.Views_Shared__ComplimentList), @"mvc.1.0.view", @"/Views/Shared/_ComplimentList.cshtml")]
namespace MVC.Views.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a91feb346b9c1f53445be5921e03bea1fc5672", @"/Views/Shared/_ComplimentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f855e6b948f5ca6e8b235ac32d530e42770293", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ComplimentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <p class=\"listheading\">Komplimanger i listan:</p>\r\n    \r\n");
#nullable restore
#line 3 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\Shared\_ComplimentList.cshtml"
       foreach (var item in ViewBag.Kindness)
    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"comploment-list\">\r\n                <p class=\"item\">");
#nullable restore
#line 6 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\Shared\_ComplimentList.cshtml"
                           Write(item.Thing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 8 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\Shared\_ComplimentList.cshtml"
    }

#line default
#line hidden
#nullable disable
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
