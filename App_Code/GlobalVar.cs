using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Web;

namespace MyApp.Namespace
{
    
  

    public static class GloVar

    {

     public static string _VarCurrNum;
     public static string _VarCurrNum2;
     public static string _VarCurrSign; 
     public static string _VarTotNum;
     public static string _VarDisplayStr;    


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


        public static string VarCurrNum2
        {
            get
            {
                return _VarCurrNum2;
            }
            set
            {
                _VarCurrNum2 = value;
            }
        }


        public static string VarCurrSign
        {
            get
            {
                return _VarCurrSign;
            }

            set
            {
                _VarCurrSign = value;

            }

        }

        public static string VarDisplayStr {

            get {

                return _VarDisplayStr;
            }

            set {

                _VarDisplayStr = value; 

            }




        }



    }


}




