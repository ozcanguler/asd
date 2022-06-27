using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class squares_of_numbers
    {
        static int x, y;
        public static void enterthenumbers()
        {
            try
            {
                Console.Write("enter the first number:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter the second number:");
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
            }
            
        }
        public static int square()
        {
            return x * x + y * y;
        }
    }
}
