#pragma checksum "C:\Users\bob\Documents\Visual Studio 2015\Projects\razor_pages\WebApp\Pages\JavaScriptCalc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2611b340240e2bb9a1a8a250d067c6e6a8959239"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2611b340240e2bb9a1a8a250d067c6e6a8959239", @"/Pages/JavaScriptCalc.cshtml")]
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
            BeginContext(58, 7300, true);
            WriteLiteral(@"

<script>
    debugger;

    $(function () {

        //gets draggable div positions fron local storage
        var sPositions = localStorage.positions || ""{}"",
            //gets positions and converts to object
            positions = JSON.parse(sPositions);
        //loops through and sets the position for div
        $.each(positions, function (id, pos) {
            $(""#"" + id).css(pos);
        });

        //targets the calculator via ID and makes it draggable
        $(""#draggable"").draggable({
            //specifies the containment DIV
            containment: ""#containment"",
            //disables scrolling inside div
            scroll: false,
            //initialed when dragging stops
            stop: function (event, ui) {
                //gets the current div position and saves it
                positions[this.id] = ui.position;
                //stores it in local storage
                localStorage.positions = JSON.stringify(positions);
            }
       ");
            WriteLiteral(@" });
    });


    //each button pressed has its own function witch adds its value to the display string
    function btn1() { document.getElementById(""display"").value += ""1"" };
    function btn2() { document.getElementById(""display"").value += ""2"" };
    function btn3() { document.getElementById(""display"").value += ""3"" };
    function btn4() { document.getElementById(""display"").value += ""4"" };
    function btn5() { document.getElementById(""display"").value += ""5"" };
    function btn6() { document.getElementById(""display"").value += ""6"" };
    function btn7() { document.getElementById(""display"").value += ""7"" };
    function btn8() { document.getElementById(""display"").value += ""8"" };
    function btn9() { document.getElementById(""display"").value += ""9"" };
    function btn0() { document.getElementById(""display"").value += ""0"" };

    function btnMulti() {
        //gets value of current display
        var display = document.getElementById(""display"").value
        //checks to see if * was pressed");
            WriteLiteral(@" when the display is blank
        if (display == """") {
            //sets default value
            display = ""0*""
            //gets the display value
            document.getElementById(""display"").value = display
        }
        //checks to see if the the operation sign was pressed mutliple times
        else if (display[display.length - 1] == ""+"" || display[display.length - 1] == ""-"" || display[display.length - 1] == ""/"" || display[display.length - 1] == ""*"") {
            //extracts the display minus the last sign pressed and adds the * sign incase the operation sign was pressed multiple times
            display = display.slice(0, -1) + ""*""
            //sets the displays value
            document.getElementById(""display"").value = display
            //if just a nummber, the * sign gets appended
        } else { document.getElementById(""display"").value += ""*"" }
    };
    function btnSub() {
        //gets value of current display
        var display = document.getElementById(""displ");
            WriteLiteral(@"ay"").value
        //checks to see if - was pressed when the display is blank
        if (display == """") {
            //sets new  default value
            display = ""0-""
            //sets display value
            document.getElementById(""display"").value = display
        }
        //checks to see if the the operation sign was pressed mutliple times
        if (display[display.length - 1] == ""+"" || display[display.length - 1] == ""-"" || display[display.length - 1] == ""/"" || display[display.length - 1] == ""*"") {
            //extracts the display minus the last sign pressed and adds the - sign incase the operation sign was pressed BEFORE
            display = display.slice(0, -1) + ""-""
            //sets the displays value
            document.getElementById(""display"").value = display
            //if just a nummber, the * sign gets appended
        } else { document.getElementById(""display"").value += ""-"" }
    };
    function btnAdd() {
        //gets value of current display
        var ");
            WriteLiteral(@"display = document.getElementById(""display"").value
        //checks to see if - was pressed when the display is blank
        if (display == """") {
            //sets new  default value
            display = ""0+""
            //sets display value
            document.getElementById(""display"").value = display
        }
        //checks to see if the the operation sign was pressed mutliple times
        if (display[display.length - 1] == ""+"" || display[display.length - 1] == ""-"" || display[display.length - 1] == ""/"" || display[display.length - 1] == ""*"") {
            //extracts the display minus the last sign pressed and adds the + sign incase the operation sign was pressed BEFORE
            display = display.slice(0, -1) + ""+""
            //sets the displays value
            document.getElementById(""display"").value = display
            //if just a nummber, the + sign gets appended
        } else { document.getElementById(""display"").value += ""+"" }
    };

    function btnDiv() {
        //g");
            WriteLiteral(@"ets value of current display
        var display = document.getElementById(""display"").value
        //checks to see if - was pressed when the display is blank
        if (display == """") {
            //sets new  default value
            display = ""0/""
            //sets display value
            document.getElementById(""display"").value = display
        }

        //checks to see if the the operation sign was pressed mutliple times
        if (display[display.length - 1] == ""+"" || display[display.length - 1] == ""-"" || display[display.length - 1] == ""/"" || display[display.length - 1] == ""*"") {
            //extracts the display minus the last sign pressed and adds the - sign incase the operation sign was pressed BEFORE
            display = display.slice(0, -1) + ""/""
            //sets the displays value
            document.getElementById(""display"").value = display
        } else { document.getElementById(""display"").value += ""/"" }
    };

    function btnEq() {
        //display string ge");
            WriteLiteral(@"ts evaluated
        var results = eval(document.getElementById(""display"").value)
        //returns the results
        document.getElementById(""display"").value = results


    };

    function btnC() {
        //clears the display
        document.getElementById(""display"").value = """"
    };

    //Jquery pop over function targeting divs that have data toggle pop over set
    $(function () {
        $('[data-toggle=""popover""]').popover()
    })



</script>


<div class=""float-right"">

    <h2 class=""display-4 mb-0"">Here is my Javascript Calculator! </h2>

</div>




<div style=""clear:right;"" class=""float-right"">
    <h3 class=""blockquote-footer"">This is written in Javascript, HTML, and CSS with elements of JQuery and Popper JS.  This is a client-side calculator that is draggable. It also remembers the drag location even after a page refresh. All calculations are done on the client's browser. </h3>
</div>




<div id=""containment"" class=""float-left"">

    <div id=""drag");
            WriteLiteral("gable\" class=\"ui-widget-content\" data-toggle=\"popover\" data-placement=\"top\" data-content=\"DRAG ME!!\" data-trigger=\"hover\">\r\n        ");
            EndContext();
            BeginContext(7358, 2459, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2611b340240e2bb9a1a8a250d067c6e6a895923910970", async() => {
                BeginContext(7364, 2446, true);
                WriteLiteral(@"
            <div>
                <table>

                    <tr>

                        <td colspan=""4"">

                            <input name=""display"" id=""display"" value="""" disabled>

                        </td>


                    </tr>

                    <tr>

                        <td> <input type=""button"" class=""btn btn-outline-success"" value=""7"" onclick=""btn7()""></td>
                        <td> <input type=""button"" class=""btn btn-outline-success"" value=""8"" onclick=""btn8()""></td>
                        <td> <input type=""button"" class=""btn btn-outline-success"" value=""9"" onclick=""btn9()""></td>
                        <td> <input type=""button"" class=""btn btn-outline-dark"" value=""x"" onclick=""btnMulti()""></td>

                    </tr>


                    <tr>

                        <td> <input type=""button"" class=""btn btn-outline-success"" value=""4"" onclick=""btn4()""></td>
                        <td> <input type=""button"" class=""btn btn-outline-success"" val");
                WriteLiteral(@"ue=""5"" onclick=""btn5()""></td>
                        <td> <input type=""button"" class=""btn btn-outline-success"" value=""6"" onclick=""btn6()""></td>
                        <td> <input type=""button"" class=""btn btn-outline-dark"" value=""-"" onclick=""btnSub()""></td>


                    </tr>

                    <tr>



                        <td> <input type=""button"" class=""btn btn-outline-success"" value=""1"" onclick=""btn1()""></td>
                        <td> <input type=""button"" class=""btn btn-outline-success"" value=""2"" onclick=""btn2()""></td>
                        <td> <input type=""button"" class=""btn btn-outline-success"" value=""3"" onclick=""btn3()""></td>
                        <td> <input type=""button"" class=""btn btn-outline-dark"" value=""+"" onclick=""btnAdd()""></td>


                    </tr>

                    <tr>

                        <td> <input type=""button"" class=""btn btn-outline-primary"" value=""C"" onclick=""btnC()""></td>

                        <td> <input type=""button"" class");
                WriteLiteral(@"=""btn btn-outline-success"" value=""0"" onclick=""btn0()""></td>
                        <td> <input type=""button"" class=""btn btn-outline-primary"" value=""="" onclick=""btnEq()""></td>

                        <td> <input type=""button"" class=""btn btn-outline-dark"" value=""/"" onclick=""btnDiv()""></td>


                    </tr>




                </table>

            </div>




        ");
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
            BeginContext(9817, 32, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
