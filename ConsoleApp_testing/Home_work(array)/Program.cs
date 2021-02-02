using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] myArr = {7,-15,0, 4, 6, 8, 13,-20};
            int min = myArr[0];
            /*int sum=o; 
              for (int i = myArr.Length-1; i >=0; i--)
            {

                if (myArr[i] % 2 == 0)
                {
                    sum += myArr[i];
                    Console.WriteLine(myArr[i]);
                };
            }
            Console.WriteLine("sum:" + sum);*/

            for (int i = 0; i <myArr.Length; i++)
            {
               
                if (myArr[i]<min)
                {
                    min = myArr[i];
                    Console.WriteLine(min);
                }
            }
            Console.WriteLine("min : " + min);
        }
    }
}
