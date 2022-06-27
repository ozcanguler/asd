using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class sum_of_cubes          
    {
            
        public static void my_cubes()
        {
            string result = "";
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    sum = sum + Math.Pow(i, 3);
                    result = result + $"{i}^3";
                    Console.WriteLine(result + "=" + sum);
                }
                else
                {
                    sum = sum + Math.Pow(i, 3);
                    result = result + $"+{i}^3";
                    Console.WriteLine(result + "=" + sum);
                }

            }

        }
        
    }
}
