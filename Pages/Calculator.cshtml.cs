using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CalculatorModel : PageModel
    {
		

		[TempData]
        public string ResultInfo { get; set; }
       
     
        [BindProperty]
        public double UsrInput { get; set; }

       
        [BindProperty]
        public double OperandInput { get; set; }
		
		
		
		
        public void OnGet()
        {	
        }

        public async Task<IActionResult> OnPostCalculateAsync(String BtnVal)
        {

            HttpContext.Cache["CachVarCurrNum"] = 0;
            HttpContext.Cache["CachVarTotNum"] = 0;


            if (string.Equals(BtnVal,'C')) {

                ResultInfo = "";
                BtnVal = "";
                HttpContext.Cache["CachVarTotNum"] = "";
                HttpContext.Cache["CachVarCurrNum"] = "";


            } if (string.Equals(BtnVal, '/')) {



            }

            if (string.Equals(BtnVal, '-')) { }

            if (string.Equals(BtnVal, '*')) { }

            if (string.Equals(BtnVal, '+')) { }

       
            else {


                HttpContext.Cache["CachVarCurrNum"] += BtnVal;
                ResultInfo = HttpContext.Cache["CachVarCurrNum"];

            }
                




            //You can use RedirectToPage with no arguments to redirect to the default GET handler of the current Razor Page.
            return RedirectToPage();






        }

    }
}