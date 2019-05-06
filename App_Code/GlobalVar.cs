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

    //declares public fields
     public static string _VarCurrNum;
     public static string _VarCurrNum2;
     public static string _VarCurrSign; 
     public static string _VarTotNum;
     public static string _VarDisplayStr;
     public static int _FirSignFlag = 0;

       //this is used to keep track of the total 
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

       

    //this is used to keep track of the number pressed before the first arithmetic sign 
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

        //this is used to keep track of the numbers pressed after the first arithmetic sign
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

        //keeps track of the arithmetic sign
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
        //keeps track of the display string. Number + arithmetic sign
        public static string VarDisplayStr {

            get {

                return _VarDisplayStr;
            }

            set {

                _VarDisplayStr = value; 

            }

        }


        //used to determine if a arithmetic sign is being used
        public static int FirSignFlag
        {

            get
            {

                return _FirSignFlag;
            }

            set
            {

                _FirSignFlag = value;

            }




        }



    }


}




