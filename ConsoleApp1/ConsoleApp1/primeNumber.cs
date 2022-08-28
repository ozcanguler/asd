using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class primeNumber
    {
        public static void yaz()
        {
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    Console.WriteLine(n);
                    sum += n;
                    ctr++;
                }
                n++;
            }
        }
       
           
public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
        public static void flo()
        {
            double a = 55;
            Console.WriteLine(Math.Sqrt(a));
        }
    }
}
