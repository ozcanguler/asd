using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Recursion
    {

        public class CountToOne
        //If the number is 1 then stop 
        //If the number is even then divide by 2
        //If the number is odd then add 1
        {
            static int num;
            public static void number()
            {
                Console.WriteLine("Enter the number please");
                num = int.Parse(Console.ReadLine());
                CountOne(num);
            }
            public static int CountOne(int c)
            {
                Console.WriteLine("C = " + c);
                if (c == 1)
                {
                    Console.WriteLine("C = " + c + " .Base Case");
                    return c;

                }
                else
                {


                    if (c % 2 == 0)
                    {
                        Console.WriteLine(c + " Number is even. Divide by 2");
                        num = c / 2;
                        //Console.WriteLine("T =" +num);
                        return CountOne(num);
                    }
                    else
                    {
                        Console.WriteLine(c + " Number is singular. Add by 1");
                        num = c + 1;
                        //Console.WriteLine("T =" +num);
                        return CountOne(num);
                    }
                }
            }
        }


        public class Factorial
        {
            static int num;
            public static void EnterNum()
            {
                Console.Write("Enter the number please: ");
                num = int.Parse(Console.ReadLine());

                while (num >= 0)
                {
                    Console.WriteLine(num + "! = " + facNum(num));
                    num--;
                }

            }

            public static int facNum(int n)
            {

                if (n > 0)
                {

                    //Console.WriteLine(facNum(n - 1) * n); 
                    return facNum(n - 1) * n;


                }
                else
                {
                    return 1;

                }
            }
        }

        public class GreatestCommonDivisor
        {
           
         static int num1;
            static int num2;
            static int temp;
            public static int enterNumbers()
            {

                Console.WriteLine("Enter the first number:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                num2 = int.Parse(Console.ReadLine());
                if (num1 > num2)
                {
                    return GCD(num1, num2);

                }
                else
                {
                    return GCD(num2, num1);
                }
            }
            public static int GCD(int n1, int n2)
            {
                num1 = n1;
                num2 = n2;


                if (num1 % num2 == 0)
                {
                    Console.WriteLine("{0} / {1} has a remainder of {2}", num1, num2, num1 % num2);
                    Console.WriteLine("GCD number is: " + num2);
                    return num2;
                }
                else
                {
                    while (num1 % num2 != 0)
                    {
                        Console.WriteLine("Not yet. {0} / {1} has a remainder of {2}", num1, num2, num1 % num2);
                        temp = num1 % num2;
                        num1 = num2;
                        num2 = temp;

                    }
                    return GCD(num1, num2);
                }
            }
        }
    }
}
