using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class multiply                  //Çarpma işleminin sonucunu toplama işlemi ile bulmak.
    {
        static int num1, num2, sum;
        static string res = "";
        public static void multi()
        {
            Console.Write("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 < 2)
            {
                res = res + $"{num1}";
                Console.WriteLine(num1);
            }
            else
            {
                
                for (int i = 0; i < num2; i++)
                {
                    if (i == 0)
                    {
                        sum = sum + num1;
                        res = res + $"{num1}";
                    }
                    else
                    {
                        sum = sum + num1;
                        res = res + $"+{num1}";
                       
                    }
                    
              }
                Console.WriteLine(res + "=" + sum);
            }
           
        }
    }
}
