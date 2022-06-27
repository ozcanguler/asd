using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class find_age
    {
        static int birth;
        public static void birthday()
        {
            try
            {
                Console.WriteLine("Enter the birthday:");
                birth = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            if (birth < 200)
            {
                Console.WriteLine("Your birthday:" + (DateTime.Now.Year - birth));
            }          
           else Console.WriteLine("Your age:"+ (DateTime.Now.Year - birth));
        }
    }
}
