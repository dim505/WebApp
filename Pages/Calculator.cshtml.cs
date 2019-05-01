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




            if (string.Equals(BtnVal, "C"))
            {

                ResultInfo = "";
                BtnVal = "";
                GloVar.VarTotNum = "";
                GloVar.VarCurrNum = "";
                GloVar.VarCurrNum2 = "0";
                GloVar.VarCurrSign = "";
                GloVar.VarDisplayStr = "";

            }
            else if (string.Equals(BtnVal, "/"))
            {
                GloVar.VarCurrSign = "/";
                GloVar.VarDisplayStr += GloVar.VarCurrSign;
                ResultInfo = GloVar.VarDisplayStr;

            }

            else if (string.Equals(BtnVal, "-")) {

                GloVar.VarCurrSign = "-";
                GloVar.VarDisplayStr += GloVar.VarCurrSign;
                ResultInfo = GloVar.VarDisplayStr;

            }


            else if (string.Equals(BtnVal, "*")) {
                GloVar.VarCurrSign = "*";
                GloVar.VarDisplayStr += GloVar.VarCurrSign;
                ResultInfo = GloVar.VarDisplayStr;
            }


            else if (string.Equals(BtnVal, "=")) {

                if (string.IsNullOrWhiteSpace(GloVar.VarCurrNum) | string.IsNullOrWhiteSpace(GloVar.VarCurrNum2))
                {



                }
                else {




                
                float VarCurrNum = Convert.ToInt32(GloVar.VarCurrNum);
                float VarCurrNum2 = Convert.ToInt32(GloVar.VarCurrNum2);
                float results = 0;
                if (string.Equals(GloVar.VarCurrSign, "+")) {
                   results = VarCurrNum + VarCurrNum2; }
                

                else if (string.Equals(GloVar.VarCurrSign, "-")) {
                    results = VarCurrNum - VarCurrNum2;

                }

                else if (string.Equals(GloVar.VarCurrSign, "*")) {
                    results = VarCurrNum * VarCurrNum2;

                }

                else if (string.Equals(GloVar.VarCurrSign, "/")) {
                    results = VarCurrNum / VarCurrNum2;

                }


                GloVar.VarTotNum = results.ToString();
                GloVar.VarCurrNum = results.ToString();
                GloVar.VarCurrNum2 = "0";
                GloVar.VarCurrSign = "";
                GloVar.VarDisplayStr = GloVar.VarTotNum;
                ResultInfo = GloVar.VarDisplayStr;

                }


            }

            else if (string.Equals(BtnVal, "+"))
            {
                GloVar.VarCurrSign = "+";
                GloVar.VarDisplayStr +=  GloVar.VarCurrSign;
                ResultInfo = GloVar.VarDisplayStr;


            }

            else if (!string.IsNullOrWhiteSpace(GloVar.VarCurrSign)) {

                GloVar.VarCurrNum2 += BtnVal;
                GloVar.VarDisplayStr += BtnVal;
                ResultInfo = GloVar.VarDisplayStr;

            }
            else
            {


                GloVar.VarCurrNum += BtnVal;
                GloVar.VarDisplayStr = GloVar.VarCurrNum;
                ResultInfo = GloVar.VarDisplayStr;

            }





            //You can use RedirectToPage with no arguments to redirect to the default GET handler of the current Razor Page.
            return RedirectToPage();






        }

    }
}