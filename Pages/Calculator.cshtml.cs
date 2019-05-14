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
        //variable used to display the text of calculator
        public string ResultInfo { get; set; }




        //FUTURE CODE OPTIMIZATION: SEE IF RESULTINFO CAN BE REMOVED AND GLODISPLAYSTR CAN BE DISPLAYED DIRECTLY
        //                          SEE IF YOU CAN GET RID OF FLAG AND CHECK FOR NULL DIRECTLY FOR SIGN
        //                          clean up any unused variables
     

        

        public void OnGet()
        {	
        }
        
        public async Task<IActionResult> OnPostCalculateAsync(String BtnVal)
        {

            

            //checks if pressed button is C
            if (string.Equals(BtnVal, "C"))
            {
                //clears out all variables
                ResultInfo = "";
                BtnVal = "";
                GloVar.VarTotNum = "";
                GloVar.VarCurrNum = "0";
                GloVar.VarCurrNum2 = "0";
                GloVar.VarCurrSign = "";
                GloVar.VarDisplayStr = "0";
                GloVar.FirSignFlag = 0;
                
            }
            //checks if pressed button is divide


            else if (string.Equals(BtnVal, "/"))
            {
                //sets the sign variable
                GloVar.VarCurrSign = "/";

                //checks if any other sign buttons have been pressed
                if (GloVar.FirSignFlag == 0) {


                    //appends sign to display string
                    GloVar.VarDisplayStr += GloVar.VarCurrSign;

                    //sets flag to 1 indicating there is a sign set
                    GloVar.FirSignFlag = 1;


                } else {

                    //replaces an other signs that may have been pressed with /
                    GloVar.VarDisplayStr = GloVar.VarDisplayStr.Replace("–", "/").Replace("+", "/").Replace("*", "/");


                }

                //sets the display variable
                ResultInfo = GloVar.VarDisplayStr;

            }

            //checks if pressed button is subtract
            else if (string.Equals(BtnVal, "–")) {
                //sets the sign variable
                GloVar.VarCurrSign = "–";

                //checks if any other sign buttons have been pressed
                if (GloVar.FirSignFlag == 0)
                {
                    //appends sign to display string
                    GloVar.VarDisplayStr += GloVar.VarCurrSign;
                    //sets flag to 1 indicating there is a sign set
                    GloVar.FirSignFlag = 1;


                }
                else
                {
                    //replaces an other signs that may have been pressed with -
                    GloVar.VarDisplayStr = GloVar.VarDisplayStr.Replace("*", "–").Replace("/", "–").Replace("+", "–");
                }
                //sets the display variable
                ResultInfo = GloVar.VarDisplayStr;

            }

            //checks if pressed button is multiply
            else if (string.Equals(BtnVal, "*")) {
                //sets the sign variable
                GloVar.VarCurrSign = "*";
                //checks if any other sign buttons have been pressed
                if (GloVar.FirSignFlag == 0)
                {
                    //appends sign to display string
                    GloVar.VarDisplayStr += GloVar.VarCurrSign;
                    //sets flag to 1 indicating there is a sign set
                    GloVar.FirSignFlag = 1;


                }
                else
                {
                    //replaces an other signs that may have been pressed with *
                    GloVar.VarDisplayStr = GloVar.VarDisplayStr.Replace("–", "*").Replace("/", "*").Replace("+", "*");
                }

                //sets the display variable
                ResultInfo = GloVar.VarDisplayStr;
            }

            //checks if pressed button is equals
            else if (string.Equals(BtnVal, "=")) {

                //checks if any numbers need to be calculated
                if (string.IsNullOrWhiteSpace(GloVar.VarCurrNum) | string.IsNullOrWhiteSpace(GloVar.VarCurrNum2))
                {
                    //replaces any possible pressed signs with a blank and returns only any possible numbers pressed
                    ResultInfo = GloVar.VarDisplayStr.Replace("–", "").Replace("/", "").Replace("+", "").Replace("*", "");
                    //returns page with specified values
                    return RedirectToPage();
                    

                }
                else {




                //declares variables for calculation and converts tracked numbers to doubles
                Double VarCurrNum = Convert.ToDouble(GloVar.VarCurrNum);
                Double VarCurrNum2 = Convert.ToDouble(GloVar.VarCurrNum2);
                Double results = 0;

                    //checks to see what the pressed arithmetic sign is and calculates the number accordingly
                    if (string.Equals(GloVar.VarCurrSign, "+")) {
                   results = VarCurrNum + VarCurrNum2; }
                

                else if (string.Equals(GloVar.VarCurrSign, "–")) {
                    results = VarCurrNum - VarCurrNum2;

                }

                else if (string.Equals(GloVar.VarCurrSign, "*")) {
                    results = VarCurrNum * VarCurrNum2;

                }

                else if (string.Equals(GloVar.VarCurrSign, "/")) {
                    results = VarCurrNum / VarCurrNum2;

                }

                //converts back to string
                GloVar.VarTotNum = results.ToString();
                GloVar.VarCurrNum = results.ToString();
                //reset all global variables
                GloVar.VarCurrNum2 = "";
                GloVar.VarCurrSign = "";
                GloVar.FirSignFlag = 0;
                //updates display string
                GloVar.VarDisplayStr = GloVar.VarTotNum;
                //sets the page variable for display
                ResultInfo = GloVar.VarDisplayStr;

                }


            }
            //checks if pressed button is add
            else if (string.Equals(BtnVal, "+"))
            {

                //sets the sign variable
                GloVar.VarCurrSign = "+";

                //checks if any other sign buttons have been pressed
                if (GloVar.FirSignFlag == 0)
                {
                    //appends sign to display string
                    GloVar.VarDisplayStr += GloVar.VarCurrSign;
                    //sets flag to 1 indicating there is a sign set
                    GloVar.FirSignFlag = 1;

                }
                else
                {
                    //replaces an other signs that may have been pressed with a + sign
                    GloVar.VarDisplayStr = GloVar.VarDisplayStr.Replace("–", "+").Replace("/", "+").Replace("*", "+");
                }
                //sets the display variable for the page
                ResultInfo = GloVar.VarDisplayStr;


            }

            //checks if any sign was pressed, if yes. It adds numbers to second number variable
            else if (!string.IsNullOrWhiteSpace(GloVar.VarCurrSign)) {
                //adds value to 2nd current number variable
                GloVar.VarCurrNum2 += BtnVal;
                //also updates global display string
                GloVar.VarDisplayStr += BtnVal;
                //updates display variable for page
                ResultInfo = GloVar.VarDisplayStr;

            }
            else
            {

                //else it adds it to the first current number variable
                GloVar.VarCurrNum += BtnVal;
                //sets the current number to the global display string
                GloVar.VarDisplayStr = GloVar.VarCurrNum;
                //sets the display string for the page
                ResultInfo = GloVar.VarDisplayStr;

            }





            //returns page with specified valuess   
            return RedirectToPage();






        }

    }
}