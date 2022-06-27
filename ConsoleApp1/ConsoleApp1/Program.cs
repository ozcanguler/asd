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

            Myname.o_z_c_a_n();

        }
    }
}
