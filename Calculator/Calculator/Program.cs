using System;

namespace Calculator
{
    public class calculator
    {
        double num1, num2, result;
        public char[] process = { '-', '+', '*', '/' };
        public char choice;
        public void accessNumbers()
        {
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToDouble(Console.ReadLine());


            //    Console.WriteLine("Enter the process { '-', '+', '*', '/' }");
            //    choice = Convert.ToChar(Console.ReadLine());

            //for (int i = 0; i < process.Length; i++)
            //{
            //    if (choice == process[i])
            //    {
            //        continue;
            //    }
            //    else if (choice != process[i]) Console.WriteLine("asdsa"); break ;

            //}


        }




    }
    class Program
    {
        static int n1, n2, top, tops;
        static char choose;
        static int sum(int k1, int k2)
        {
            return k1 + k2;
        }
        static int subtract(int k1, int k2)
        {
            return k1 - k2;
        }
        static int multiply(int k1, int k2)
        {
            return k1 * k2;
        }
        static int divide(int k1, int k2)
        {
            return k1 / k2;
        }
        public static void transactions()
        {

            switch (choose)
            {
                case '+':
                    { top = sum(n1, n2); Console.WriteLine("{0}+{1}={2}", n1, n2, top); tops = top; }
                    break;
                case '-':
                    { top = subtract(n1, n2); Console.WriteLine("{0}-{1}={2}", n1, n2, top); tops = top; }
                    break;
                case '*':
                    { top = multiply(n1, n2); Console.WriteLine("{0}*{1}={2}", n1, n2, top); tops = top; }
                    break;
                case '/':
                    { top = divide(n1, n2); Console.WriteLine("{0}/{1}={2}", n1, n2, top); tops = top; }
                    break;
            }
        }
        public static void transactions1()
        {

            switch (choose)
            {

                case '+':
                    { tops = sum(top, n2); Console.WriteLine("{0}+{1}={2}", top, n2, tops); top = tops; }
                    break;
                case '-':
                    { tops = subtract(top, n2); Console.WriteLine("{0}-{1}={2}", top, n2, tops); top = tops; }
                    break;
                case '*':
                    { tops = multiply(top, n2); Console.WriteLine("{0}*{1}={2}", top, n2, tops); top = tops; }
                    break;
                case '/':
                    { tops = divide(top, n2); Console.WriteLine("{0}/{1}={2}", top, n2, tops); top = tops; }
                    break;
            }
        }

        static void Main(string[] args)
        {
            char choise;
            Console.WriteLine("first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the operand {+}{-}{*}{/}");
            choose = Convert.ToChar(Console.ReadLine());
            transactions();
            while (true)
            {
                Console.WriteLine("If you want to finish the calculation, press f . Otherwise press something else.");
                choise = Convert.ToChar(Console.ReadLine());
                if (choise == 'f') { Console.WriteLine("İşlem sonlandı"); break; }
                else
                {
                    Console.WriteLine("second number");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose the operand {+}{-}{*}{/}");
                    choose = Convert.ToChar(Console.ReadLine());
                    transactions1();
                }
            }

        }




    }



}
