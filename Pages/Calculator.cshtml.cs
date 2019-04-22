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

        public void OnPostCalculate(String BtnVal)
        {


            ResultInfo = BtnVal;

            ViewData["result"] = $"{ResultInfo}";






        }

    }
}