#pragma checksum "C:\Users\bob\Documents\Visual Studio 2015\Projects\razor_pages\WebApp\Pages\JavaScriptCalc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43078eb292393e59e1d5ccb469513451ac8d8d51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(razor_pages.Pages.Pages_JavaScriptCalc), @"mvc.1.0.razor-page", @"/Pages/JavaScriptCalc.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/JavaScriptCalc.cshtml", typeof(razor_pages.Pages.Pages_JavaScriptCalc), null)]
namespace razor_pages.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\bob\Documents\Visual Studio 2015\Projects\razor_pages\WebApp\Pages\_ViewImports.cshtml"
using razor_pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43078eb292393e59e1d5ccb469513451ac8d8d51", @"/Pages/JavaScriptCalc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d45e63f997e68bd8ec1dfbd8cb9a4057c4fad5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_JavaScriptCalc : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2301, true);
            WriteLiteral(@"

<script>

    //$(document).ready(function () {
    $(function () {

        var sPositions = localStorage.positions || ""{}"",
            positions = JSON.parse(sPositions);
        $.each(positions, function (id, pos) {
            $(""#"" + id).css(pos);
        });
        $(""#draggable"").draggable({
            containment: ""#containment"",
            scroll: false,
            stop: function (event, ui) {
                positions[this.id] = ui.position;
                localStorage.positions = JSON.stringify(positions);
            }
        });



    });
     //   });



    function btn1() { document.getElementById(""display"").value += ""1"" };
    function btn2() { document.getElementById(""display"").value += ""2"" };
    function btn3() { document.getElementById(""display"").value += ""3"" };
    function btn4() { document.getElementById(""display"").value += ""4"" };
    function btn5() { document.getElementById(""display"").value += ""5"" };
    function btn6() { document.getElemen");
            WriteLiteral(@"tById(""display"").value += ""6"" };
    function btn7() { document.getElementById(""display"").value += ""7"" };
    function btn8() { document.getElementById(""display"").value += ""8"" };
    function btn9() { document.getElementById(""display"").value += ""9"" };
    function btn0() { document.getElementById(""display"").value += ""0"" };
    function btnMulti() {
        var display = document.getElementById(""display"").value
        if (display[display.length -1] == ""+"" || display[display.length -1] == ""-"" || display[display.length -1] == ""/"" {



        }
        document.getElementById(""display"").value += ""*""
    };
    function btnSub() { document.getElementById(""display"").value += ""-"" };
    function btnAdd() { document.getElementById(""display"").value += ""+"" };
    function btnEq() {
        var results = eval(document.getElementById(""display"").value )
        document.getElementById(""display"").value = results


    };
    function btnDec() { document.getElementById(""display"").value += ""."" };
   ");
            WriteLiteral(" function btnC() { document.getElementById(\"display\").value = \"\" };\r\n</script>\r\n\r\n\r\n\r\n<h1>Here is my Javascript Calculator! Written in Javascript,HTML and CSS</h1>\r\n\r\n\r\n<div id=\"containment\">\r\n    <div id=\"draggable\" class=\"ui-widget-content\">\r\n        ");
            EndContext();
            BeginContext(2359, 2066, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43078eb292393e59e1d5ccb469513451ac8d8d515735", async() => {
                BeginContext(2365, 2053, true);
                WriteLiteral(@"

            <table>
                <tr>
                    
                    <td colspan=""4"">

                        <input name=""display"" id=""display"" value="""" disabled> 

                    </td>
                    
                    
                 </tr>
                <tr>

                    <td> <input type=""button"" class=""btn""  value=""7"" onclick=""btn7()""></td>
                    <td> <input type=""button"" class=""btn""  value=""8"" onclick=""btn8()""></td>
                    <td> <input type=""button"" class=""btn""  value=""9"" onclick=""btn9()""></td>
                    <td> <input type=""button"" class=""btn""  value=""x"" onclick=""btnMulti()""></td>

                </tr>


                <tr>

                    <td> <input type=""button"" class=""btn""  value=""4"" onclick=""btn4()""></td>
                    <td> <input type=""button"" class=""btn""  value=""5"" onclick=""btn5()""></td>
                    <td> <input type=""button"" class=""btn""  value=""6"" onclick=""btn6()""></td>
      ");
                WriteLiteral(@"              <td> <input type=""button"" class=""btn""  value=""-"" onclick=""btnSub()""></td>


                </tr>

                <tr>



                    <td> <input type=""button"" class=""btn""  value=""1"" onclick=""btn1()""></td>
                    <td> <input type=""button"" class=""btn""  value=""2"" onclick=""btn2()""></td>
                    <td> <input type=""button"" class=""btn""  value=""3"" onclick=""btn3()""></td>
                    <td> <input type=""button"" class=""btn""  value=""+"" onclick=""btnAdd()""></td>


                </tr>

                <tr>

                    <td> <input type=""button"" class=""btn""  value=""."" onclick=""btnDec()""></td>
                    <td> <input type=""button"" class=""btn""  value=""0"" onclick=""btn0()""></td>
                    <td> <input type=""button"" class=""btn""  value=""C"" onclick=""btnC()""></td>
                    <td> <input type=""button"" class=""btn""  value=""="" onclick=""btnEq()""></td>



                </tr>





            </table>






   ");
                WriteLiteral("     ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4425, 36, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.JavaScriptCalcModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.JavaScriptCalcModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.JavaScriptCalcModel>)PageContext?.ViewData;
        public MyApp.Namespace.JavaScriptCalcModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
