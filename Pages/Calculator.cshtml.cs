using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp.Namespace;

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
            
            GloVar.VarTotNum = "";
            GloVar.VarCurrNum = "";


            if (string.Equals(BtnVal,"C")) {
              
                ResultInfo = "";
                BtnVal = "";
                GloVar.VarTotNum = "";
                GloVar.VarCurrNum = "";


            } else if (string.Equals(BtnVal, '/')) {
              
                

            }

            else if (string.Equals(BtnVal, '-')) { }

            else if (string.Equals(BtnVal, '*')) { }

            else if (string.Equals(BtnVal, '+')) { }

       
            else {


                GloVar.VarCurrNum += BtnVal;
                ResultInfo = GloVar.VarCurrNum;

            }





            //You can use RedirectToPage with no arguments to redirect to the default GET handler of the current Razor Page.
            return RedirectToPage();






        }

    }
}