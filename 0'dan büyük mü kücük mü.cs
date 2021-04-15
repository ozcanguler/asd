using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double num;
            Console.Write("Enter the number pls:");
            num = Convert.ToDouble(Console.ReadLine());
            if (num < 0) { Console.WriteLine("number less than Zero"); }
            else if (num > 0) { Console.WriteLine("number greater than Zero"); }
            else Console.WriteLine("number equal to Zero");
        }
    }
}
