using System;
using System.Globalization;


namespace ConsoleApp_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        break;
                    }
                    
                }
                
                    for (int k = number; k >i; k--)
                    {
                    
                    if (i % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        break;
                    }

                }  
                Console.WriteLine();
            };
            Console.ReadLine();
            
        }
        
    }
}
