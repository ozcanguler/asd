using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class reverseString
    {
        string name = "Hello World";
        char[] asd;


        public void showReverse()
        {

            asd = name.ToCharArray();
            int leng = asd.Length;
            Console.Write(name + " spelled backwards is ");
            for (int i = leng - 1; i >= 0; i--)
            {
                Console.Write(asd[i]);
            }
        }

    }
}