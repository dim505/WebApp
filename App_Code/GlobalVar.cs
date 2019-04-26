using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Web;

namespace MyApp.Namespace
{
    
  
        /// <summary>
        /// Contains my site's global variables.
    /// </summary>
    public static class GloVar

    {
        /// <summary>
        /// Global variable storing important stuff.
        /// </summary>
     public static string _VarCurrNum;



      public static string _VarTotNum;


    public static string VarTotNum
    {
        get
        {
            return _VarTotNum;
        }
        set
        {
            _VarTotNum = value;
        }
    }

       

        /// <summary>
        /// Get or set the static important data.
        /// </summary>
        public static string VarCurrNum
        {
            get
            {
                return _VarCurrNum;
            }
            set
            {
                _VarCurrNum = value;
            }
        }




    }



}




