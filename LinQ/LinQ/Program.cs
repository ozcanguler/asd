using System;
using System.Linq;

namespace LinQ
{
    class Program
    {
        public static int[] nums = { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };
        public static int first;
        public static void nameLinq()
        {
            string[] names = { "Steve", "Marry", "Chris", "Bill", "Shad" };
            var myLinkQuery = from name in names
                              where name.Contains('a')
                              select name;

            foreach (var item in myLinkQuery)
            {
                Console.WriteLine(item);
            }
        }
        public static void numberLinq()
        {


            foreach (var item in nums)
            {
                Console.WriteLine("One of the numbers was {0}", item);
                first = item;

            }

            var bestNumber = from num in nums
                             where num > 90
                             select num;
            foreach (var items in bestNumber)
            {

                Console.WriteLine("bestnumbers {0}", items);
            }
        }
        public static void sortedLinq()
        {


            var sortNumber = from num in nums
                             orderby num        //descending
                             select num;
            foreach (var items in sortNumber)
            {

                Console.WriteLine("sortedNumbers {0}", items);
            }
        }

        public static void sortedSpaceLinq()        //print a list of only (%80 to %89) in descending order
        {


            var sortNumber = from num in nums
                             where num > 80 && num < 89
                             orderby num descending       //descending
                             select num;
            foreach (var items in sortNumber)
            {

                Console.WriteLine("sortedSpaceNumbers {0}", items);
            }
        }

        static void Main(string[] args)
        {
            //nameLinq();
            //numberLinq();
            //sortedLinq();
            sortedSpaceLinq();

        }
    }
}

