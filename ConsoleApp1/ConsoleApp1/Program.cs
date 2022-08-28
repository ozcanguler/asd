using System;

namespace ConsoleApp1
{
    class Program
    {
       
     
        static int sum(int x,int y)
        {
            return x + y;
        }
        static void show(int k)
        {
            Console.WriteLine(k);
        }
       
        static void Main(string[] args)
        {
            /*       int x, y;
                   //try
                   //{

                   //    Console.WriteLine("enter the first number");
                   //    x = Convert.ToInt32(Console.ReadLine());
                   //    if (x.GetType().Name != "Int32")
                   //    {
                   //        Console.WriteLine("sayı girin");
                   //        x = Convert.ToInt32(Console.ReadLine());
                   //    }
                   //    Console.WriteLine("enter the second number");
                   //    y = Convert.ToInt32(Console.ReadLine());
                   //    Console.WriteLine("{0}+{1}={2}", x, y, x + y);


                   while (true)
                   {
                       try
                       {
                           Console.Write("Enter the first number:");
                           x = Convert.ToInt32(Console.ReadLine());
                           if (x.GetType().Name == "Int32")
                           {
                               show(x); break;
                           }


                       }
                       catch(Exception ex)
                       {
                           Console.WriteLine(ex.Message);
                       }             

                   }
                   while (true)
                   {
                       try
                       {
                           Console.Write("Enter the second number:");
                           y = Convert.ToInt32(Console.ReadLine());
                           if (y.GetType().Name == "Int32")
                           {
                               show(y);break;
                           }


                       }
                       catch (Exception ex)
                       {
                           Console.WriteLine(ex.Message);
                       }



                   }
                   Console.WriteLine("{0}+{1}={2}",x, y, sum(x, y));
                   //            catch (Exception e)
                   //            {
                   //                if (e.Message != "") { 
                   //}
                   //                Console.WriteLine(e.Message);

                   //            }
                   */

            //Myname.o();
            //Myname.z();

            //squares_of_numbers.enterthenumbers();
            //Console.WriteLine(squares_of_numbers.square());


            // sum_of_cubes.my_cubes();
            //find_age.birthday();

            // factorial.fact();

            //Console.WriteLine(factorial.rec(factorial.number()));

            //multiply.multi();

            //divide.div();

            // digit.div();

            // three_digit_sum_of_cubes.calculate();

            //Myname.o_z_c_a_n();

            /*
            char ftemp;
            char ltemp;
            float say = 0;
            while (true)
            {
                Console.WriteLine("Enter the temperature (number please!)");
                try
                {
                    say = float.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    continue;

                }

                while (true)
                {
                    Console.WriteLine("c/k/f");
                    ftemp = Console.ReadLine()[0];

                    if (ftemp == 'c' || ftemp == 'f' || ftemp == 'k')
                    {
                        break;
                    }
                    continue;
                }
                while (true)
                {
                    Console.WriteLine("c/k/f");
                    ltemp = Console.ReadLine()[0];

                    if (ltemp == 'c' || ltemp == 'f' || ltemp == 'k')
                    {
                        break;
                    }
                    continue;
                }

                calculatetemperature calculate = new calculatetemperature(say, ftemp);
                switch (ltemp)
                {
                    case 'c':
                        Console.WriteLine(say + " " + ftemp + " to " + calculate.toCelsius() + " " + ltemp);
                        break;
                    case 'k':
                        Console.WriteLine(say + " " + ftemp + " to " + calculate.toKelvin() + " " + ltemp);
                        break;
                    case 'f':
                        Console.WriteLine(say + " " + ftemp + " to " + calculate.toFahrenheight() + " " + ltemp);
                        break;
                }
            }
            */

            /*
            SkylineFormat skyline = new SkylineFormat();

            skyline.showFirstName();
            skyline.UpperAndLower();
            */

            /*
            reverseString reverse = new reverseString();
            reverse.showReverse();
            */

            //swapLetters swap = new swapLetters();
            //swap.convert();
            //swap.listCharacter();

            //BinarySearch.searc(BinarySearch.numbers, BinarySearch.numbers[3], 0, BinarySearch.len);

            //Recursion.CountToOne.number();
            //Recursion.Factorial.EnterNum();
            //Recursion.GreatestCommonDivisor.enterNumbers();

            //KnightsTour.solveKT();


            //Console.WriteLine(centuryFromYear.centuryFrom_Year(17));

            //centuryFromYear.multiplyNumber.entertTheNumber();

            //centuryFromYear.substring.first_last("Fener");
            //centuryFromYear.longestWord.longest();

            //centuryFromYear.test.abs();

            //primeNumber.yaz();

            primeNumber.flo();
        }
    }
}
