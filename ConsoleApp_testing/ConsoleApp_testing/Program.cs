using System;
using System.Globalization;


namespace ConsoleApp_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo() {
                NumberDecimalSeparator = ".",
            };
            /* string str,str2,str3;
             int num1, num2, sum;
             str2 = "1.45";
             str3 = "6";


             Console.WriteLine("paste number 1");
              str = Console.ReadLine();
             num1 = Convert.ToInt32(str);

             Console.WriteLine("paste number 2");
             str = Console.ReadLine();
             num2 = Convert.ToInt32(str);

             Console.WriteLine("sum is:");
             sum = num1 + num2;
             Console.WriteLine(sum);

             double doubleNum1=Convert.ToDouble(str2,numberFormatInfo);
             int doubleNum2 = Convert.ToInt32(str3);
             double doubleSum = doubleNum1 + doubleNum2;

             Console.WriteLine("double num:" + doubleSum);*/

            /*parsing number to convert*/


            string str="1,6";

            double num = double.Parse(str, numberFormatInfo);

            Console.WriteLine("num : "+num);
            Console.WriteLine(num);



        }
    }
}
