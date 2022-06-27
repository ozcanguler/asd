using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class digit
    {
        static double num1=2, divnum=10, dig=1, remainder,truenum;

        public static void div()
        {
            truenum = num1;
            if (num1 < divnum)
            {
                Console.WriteLine(truenum+" Number of digits:"+dig++);
            }
            else
            {

            
            while (true)
            {
                
                remainder = num1 / divnum;
                dig++;
                if (remainder < divnum)
                {
                    
                    
                    Console.WriteLine(truenum + " Number of digits:" + dig);break;
                }
                else
                {
                    num1 = remainder;
                   
                }

            }

            }
        }

    }
}
