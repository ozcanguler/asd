using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class factorial
    {
        static int num, fac = 1;
        public static void fact()
        {
           
            Console.Write("enter the number:");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fac = fac * (i);
            }
            Console.WriteLine(fac);
        }
        public static int rec(int say)
        {
            if (say < 1)
            {
                return 1;
            }
            //Console.Write("enter the number:");
            //num = Convert.ToInt32(Console.ReadLine());
           return rec(say-1) * (say);
        }
        public static int number()
        {
           
            Console.Write("enter the number:");
           return num = Convert.ToInt32(Console.ReadLine());
           
        }
    }
}
