using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class divide
    {
        static double num1, divnum, result, remainder;

        public static void numbers()
        {
            Console.WriteLine("Enter the number to divide");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number to dividing");
            divnum = Convert.ToDouble(Console.ReadLine());
            if (num1 < divnum)
            {
                Console.WriteLine("Please enter the num1>=divnum");
                numbers();
            }
        }
        public static void div()
        {
        
            numbers();
            remainder = num1 % divnum;
            while (true)
            {

                num1 = num1 - divnum;
                result++;
                if (num1 == remainder) break;

            }
           
            Console.WriteLine("Result:"+(result+(remainder/divnum)));
        }
 
    }
}
