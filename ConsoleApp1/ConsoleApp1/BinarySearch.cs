using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BinarySearch
    {

        public static int[] numbers = new int[10] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100 };        //must be sorted

        public static int len = numbers.Length;

        public static int mid, i = 0;




        public static void searc(int[] array, int x, int left, int right)
        {

            if (left > right)
            {
                i++;


            }
            mid = left + ((right - left) / 2);
            
            if (array[mid] == x)
            {
                i++;
                Console.WriteLine(array[mid]);
                Console.WriteLine("Number of iteration:" + i);

            }
            else if (x < array[mid])
            {
                i++;
                Console.WriteLine(array[mid]);
                searc(array, x, left, mid - 1);
            }
            else
            {
                i++;
                Console.WriteLine(array[mid]);
                searc(array, x, mid + 1, right);
            }

        }

    }
}
