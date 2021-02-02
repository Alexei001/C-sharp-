using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorks_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*exersise one, arithmetic media of two number*/
            /*
                        int num1, num2;
                        double result;

                        Console.WriteLine("enter first number");
                        string data = Console.ReadLine();

                        num1 = int.Parse(data);

                        Console.WriteLine("enter second number");
                        data = Console.ReadLine();

                        num2 = int.Parse(data);

                        result = (num1 + (double)num2) / 2;
                        Console.WriteLine("result : "+result);*/


            /*int a, b, c;

            Console.WriteLine("enter first number");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter third number");
            c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            double result = (double)a / b / c;

            Console.WriteLine("sum : " + sum);
            Console.WriteLine("result :" + result);*/

            /*convert money*/
            double USDtoMDL = 17.29,EURtoMDL=20.93;
            Console.WriteLine("enter MDL: ");
            double MDLei = double.Parse(Console.ReadLine());

            Console.WriteLine(MDLei + "to Usd: " + MDLei/USDtoMDL);
            Console.WriteLine(MDLei + "to Eur: " + MDLei / EURtoMDL);
            Console.WriteLine("Eur Cours: " + EURtoMDL + " , Usd cours: " + USDtoMDL);
        }
    }
}
