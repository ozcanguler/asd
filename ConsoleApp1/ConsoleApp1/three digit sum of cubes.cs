using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class three_digit_sum_of_cubes
    {
        static int num,i,j,k,sum,remainder,dig,truenum;     // 3 basamaklı sayının her basamağının küpünün toplamı sayının kendisine eşit mi?

        static void digit()
        {

            Console.WriteLine("Enter the 3 digit number");
            num = Convert.ToInt32(Console.ReadLine());
            truenum = num;
        }
        public static void calculate()
        {


            digit();
            
            while (true)
            {

                
                remainder = num / 10;
                dig++;
                if (remainder < 10)
                {


                    if (dig + 1 != 3)
                    {
                        dig = 0;
                        digit();
                    }
                    else  break;
                }
                else
                {
                    num = remainder;

                }
                

            }


            k = truenum % 10;
            i = truenum / 10;
            j = i;
            j = j % 10;
            i = i / 10;

            i = Convert.ToInt32(Math.Pow(i, 3));
            j = Convert.ToInt32(Math.Pow(j, 3));
            k = Convert.ToInt32(Math.Pow(k, 3));
            sum = i + j + k;
            if (truenum == sum)
            {
                Console.WriteLine($"{truenum} Equal {sum}");
            }
            else
            {
                Console.WriteLine($"{truenum} Non Equal {sum}");
            }
            
            
            //Console.WriteLine("{0}{1}{2}",i,j,k);
        }
    }
}
