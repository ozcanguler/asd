using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,fac=1;
            Console.WriteLine("Enter the factorial number");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                fac = fac*(i+1);
               
            }
            Console.WriteLine("Factorial number:"+fac);
        }
        
    }
}
