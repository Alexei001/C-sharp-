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

            /*int[] myArr = {7,-15,0, 4, 6, 8, 13,-20};
            int min = myArr[0];
            *//*int sum=o; 
              for (int i = myArr.Length-1; i >=0; i--)
            {

                if (myArr[i] % 2 == 0)
                {
                    sum += myArr[i];
                    Console.WriteLine(myArr[i]);
                };
            }
            Console.WriteLine("sum:" + sum);*//*

            for (int i = 0; i <myArr.Length; i++)
            {
               
                if (myArr[i]<min)
                {
                    min = myArr[i];
                    Console.WriteLine(min);
                }
            }
            Console.WriteLine("min : " + min);*/

            int[,] myArr = { 
             {0,5,34,-8,-6 },
            {6,8,34,6,7 },
            {-13,-34,71,65,4 },
            {5,8,12,-6,-3 }
            };

            int min = myArr[0, 0];
            int max = myArr[0, 0];
            int height = myArr.GetLength(0);
            int width = myArr.GetLength(1);

            for (int y = 0; y <height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                     if (myArr[y, x] < min)
                     {
                         min = myArr[y, x];
                     }else if (myArr[y, x] > max)
                     {
                         max = myArr[y, x];

                     };

                };
            };
            Console.WriteLine($"max num is:{max}\tmin num is:{min}");
        }
    }
}
