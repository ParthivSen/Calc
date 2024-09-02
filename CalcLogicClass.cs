using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLogic
{
    public class CalcLogicClass : CalcInterface
    {
        static double num1, num2;
        static string expression;
        static string option = "";
        static double res;
        static NumberFormatInfo culture = CultureInfo.CurrentCulture.NumberFormat;
        static string decimalSep = culture.CurrencyDecimalSeparator;


        public string CheckTxtRcntLogic(string num)
        {
            //var clone = Thread.CurrentThread.CurrentCulture.Clone() as NumberFormatInfo;
            //double temp = double.Parse(num);
            //int[] mySizes1 = { 3, 2 };
            //clone.CurrencyGroupSizes = mySizes1;
            //return temp.ToString("C",clone);
            return num;
        }

        public string OperatorsLogic(double num, string ops)
        {
            option = ops;
            num1 = num;
            expression = num1 + " " + ops;
            return expression;
        }

        public string ResultLogic(double num2)
        {
            if (option == "+")
            {
                res = num1 + num2;
            }

            if (option == "-")
            {
                res = num1 - num2;
            }

            if (option == "x" || option == "×")
            {
                res = num1 * num2;
            }

            if (option == "/" || option == "÷")
            {
                res = num1 / num2;
            }
            return res.ToString();
        }

        public string DecimalLogic(string TxtMain)
        {
            if (TxtMain.Contains(decimalSep))
            {
                TxtMain += "";
            }
            else
            {
                TxtMain += decimalSep;
            }
            return TxtMain;
        }

        public double NegationLogic(double num)
        {
            return num == 0 ? 0 : num * -1;
        }
        public string BackSpaceLogic(string TxtMain)
        {
            if (!String.IsNullOrEmpty(TxtMain))
            {
                TxtMain = TxtMain.Substring(0, TxtMain.Length - 1);
            }
            if (String.IsNullOrEmpty(TxtMain))
            {
                TxtMain = "0";
            }
            return TxtMain;
        }

        public string CancelAllLogic()
        {
            return "0";
        }

        public string CancelRcntLogic()
        {
            return "0";
        }

        public double FractionLogic(double num)
        {
            return 1 / num;
        }

        public double SquareLogic(double num)
        {
            res = Math.Pow(num, 2);
            return res;
        }

        public double SqrtLogic(double num)
        {
            res = Math.Sqrt(num);
            return res;
        }

        public double PercentLogic(string TxtMain, string TxtRcnt)
        {
            if (TxtRcnt.Length == 0)
            {
                TxtMain = "0";
                TxtRcnt = "0";
            }
            else
            {
                double percent = double.Parse(TxtMain);
                if (TxtRcnt == "0")
                {
                    TxtRcnt = "0";
                    TxtMain = "0";
                }
                else if (option == "\u00d7")
                {
                    num2 = percent / 100;
                    TxtMain = num2 + "";
                }
                else if (TxtRcnt.Substring(TxtRcnt.Length - 1, 1) == "=")
                {
                    res *= res / 100;
                }
                else
                {
                    num1 = double.Parse(TxtRcnt.Substring(0, TxtRcnt.Length - 1));

                    num2 = percent * num1 / 100;

                    TxtMain = num2 + "";
                }

            }
            return num2;
        }
    }
}
