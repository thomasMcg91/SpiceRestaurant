#pragma checksum "C:\Users\mcgth\source\repos\Spice\Spice\Views\Shared\_ThumbNailAreaPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfa18f37f7c69a3fe235286a62f8d124795c53c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThumbNailAreaPartial), @"mvc.1.0.view", @"/Views/Shared/_ThumbNailAreaPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ThumbNailAreaPartial.cshtml", typeof(AspNetCore.Views_Shared__ThumbNailAreaPartial))]
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
#line 1 "C:\Users\mcgth\source\repos\Spice\Spice\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#line 2 "C:\Users\mcgth\source\repos\Spice\Spice\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa18f37f7c69a3fe235286a62f8d124795c53c7", @"/Views/Shared/_ThumbNailAreaPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1390ba8093fb4c2e21d25b459146d9962f6bcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThumbNailAreaPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mcgth\source\repos\Spice\Spice\Views\Shared\_ThumbNailAreaPartial.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(60, 90, true);
            WriteLiteral("    <div class=\"col-12\">\r\n        <div class=\"row\">\r\n            <h3 class=\"text-success\">");
            EndContext();
            BeginContext(151, 36, false);
#line 7 "C:\Users\mcgth\source\repos\Spice\Spice\Views\Shared\_ThumbNailAreaPartial.cshtml"
                                Write(Model.FirstOrDefault().Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(187, 35, true);
            WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 10 "C:\Users\mcgth\source\repos\Spice\Spice\Views\Shared\_ThumbNailAreaPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
