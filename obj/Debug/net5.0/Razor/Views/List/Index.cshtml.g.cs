#pragma checksum "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\List\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cc3740361ea91620750474c4d5470923e278727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MVC.Views.List.Views_List_Index), @"mvc.1.0.view", @"/Views/List/Index.cshtml")]
namespace MVC.Views.List
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cc3740361ea91620750474c4d5470923e278727", @"/Views/List/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f855e6b948f5ca6e8b235ac32d530e42770293", @"/Views/_ViewImports.cshtml")]
    public class Views_List_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MVC.Models.KindThings>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ListMenu1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\List\Index.cshtml"
  
    ViewData["Titel"] = "Snälla saker";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"kindness-list\">\r\n\r\n    <section>\r\n        <h2>Här finns några komplimanger till dig</h2>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\List\Index.cshtml"
         foreach (var item in Model)
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 256, "\"", 286, 2);
#nullable restore
#line 13 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\List\Index.cshtml"
WriteAttributeValue("", 264, item.Color, 264, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 275, "compliment", 276, 11, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <p");
            BeginWriteAttribute("class", " class=\"", 312, "\"", 335, 1);
#nullable restore
#line 14 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\List\Index.cshtml"
WriteAttributeValue("", 320, item.Textcolor, 320, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\List\Index.cshtml"
                                          Write(item.Thing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 2\MVC\Views\List\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2cc3740361ea91620750474c4d5470923e2787274990", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n</div>\r\n\r\n\r\n\r\n\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MVC.Models.KindThings>> Html { get; private set; }
    }
}
#pragma warning restore 1591
