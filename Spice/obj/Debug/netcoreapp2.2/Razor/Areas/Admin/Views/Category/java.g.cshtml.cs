#pragma checksum "C:\Users\mcgth\source\repos\Spice\Spice\Areas\Admin\Views\Category\java.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10b519db6bfc8d9c43c151e9e5343c70c8eef265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_java), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/java.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/java.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_java))]
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
#line 1 "C:\Users\mcgth\source\repos\Spice\Spice\Areas\Admin\Views\Category\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#line 2 "C:\Users\mcgth\source\repos\Spice\Spice\Areas\Admin\Views\Category\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b519db6bfc8d9c43c151e9e5343c70c8eef265", @"/Areas/Admin/Views/Category/java.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8587559af7d6b72be9c399a902a50d76dfe08cd", @"/Areas/Admin/Views/Category/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_java : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("quizForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return submitAnswers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n\r\n    ");
            EndContext();
            BeginContext(33, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10b519db6bfc8d9c43c151e9e5343c70c8eef2654460", async() => {
                BeginContext(39, 116, true);
                WriteLiteral("\r\n        <title>JS Quizz</title>\r\n        <link rel=\"stylesheet\" href=\"\" />\r\n        <script src=\"\"></script>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(170, 2519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10b519db6bfc8d9c43c151e9e5343c70c8eef2655777", async() => {
                BeginContext(176, 245, true);
                WriteLiteral("\r\n        <div id=\"container\">\r\n            <header>\r\n                <h1>Quizz</h1>\r\n                <p>Test JS knowledge fundamentals</p>\r\n            </header>\r\n            <section>\r\n                <div id=\"results\"></div>\r\n                ");
                EndContext();
                BeginContext(421, 2215, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10b519db6bfc8d9c43c151e9e5343c70c8eef2656423", async() => {
                    BeginContext(475, 2154, true);
                    WriteLiteral(@"
                    <h3>1. In which HTML element do we put in JavaScript code?</h3>
                    <input type=""radio"" name=""q1"" value=""a"" id=""q1a"">a. &lt;js&gt;<br>
                    <input type=""radio"" name=""q1"" value=""b"" id=""q1b"">b. &lt;script&gt;<br>
                    <input type=""radio"" name=""q1"" value=""c"" id=""q1c"">c. &lt;body&gt;<br>
                    <input type=""radio"" name=""q1"" value=""d"" id=""q1d"">d. &lt;link&gt;<br>

                    <h3>2. Which HTML attribute is used to reference an external JavaScript file?</h3>
                    <input type=""radio"" name=""q2"" value=""a"" id=""q2a"">a. src<br>
                    <input type=""radio"" name=""q2"" value=""b"" id=""q2b"">b. rel<br>
                    <input type=""radio"" name=""q2"" value=""c"" id=""q2c"">c. type<br>
                    <input type=""radio"" name=""q2"" value=""d"" id=""q2d"">d. href<br>

                    <h3>3. How would you write ""Hello"" in an alert box?</h3>
                    <input type=""radio"" name=""q3"" value=""a"" id=""q");
                    WriteLiteral(@"3a"">a. msg(""Hello"");<br>
                    <input type=""radio"" name=""q3"" value=""b"" id=""q3b"">b. alertBox(""Hello"");<br>
                    <input type=""radio"" name=""q3"" value=""c"" id=""q3c"">c. document.write(""Hello"");<br>
                    <input type=""radio"" name=""q3"" value=""d"" id=""q3d"">d. alert(""Hello"");<br>

                    <h3>4. JavaScript is directly related to the ""Java"" programming language</h3>
                    <input type=""radio"" name=""q4"" value=""a"" id=""q4a"">a. True<br>
                    <input type=""radio"" name=""q4"" value=""b"" id=""q4b"">b. False<br>

                    <h3>5. A variable in JavaScript must start with which special character</h3>
                    <input type=""radio"" name=""q5"" value=""a"" id=""q5a"">a. ^<br>
                    <input type=""radio"" name=""q5"" value=""b"" id=""q5b"">b. $<br>
                    <input type=""radio"" name=""q5"" value=""c"" id=""q5c"">c. #<br>
                    <input type=""radio"" name=""q5"" value=""d"" id=""q5d"">d. No Special Character<br>
      ");
                    WriteLiteral("              <br><br>\r\n                    <input type=\"submit\" value=\"Submit Answers\">\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2636, 46, true);
                WriteLiteral("\r\n            </section>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2689, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591