using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class centuryFromYear
    {
        public static int centuryFrom_Year(int year)
        {
            return (year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

       public class multiplyNumber
            {
            public static int multiplyNumbers(int lastNumber, int k)
            {

                if (k > 10)
                {
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{lastNumber} * {k} = " + lastNumber * k);
                    k++;
                }

                return multiplyNumbers(lastNumber, k);

            }
            public static void entertTheNumber()
            {
                int i = 0;
                int num;
                Console.Write("Enter the number:");
                num = int.Parse(Console.ReadLine());
                multiplyNumbers(num, i);
            }
        }
        public class substring
        {
            public static string first_last(string ustr)        //Substring ilk parametre  kaçıncı indeksten başlasın ikinci parametre ise kaç index alınacak.
            {
                //return ustr.Length > 1 ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
                Console.WriteLine(ustr.Length > 1 ? ustr.Substring(ustr.Length-1)+ ustr.Substring(1,ustr.Length-2)+ ustr.Substring(0,1) : ustr);
                return ustr.Length > 1 ? ustr.Substring(ustr.Length -1)  : ustr;
            }
        }

        public class longestWord
        {
            public static void longest()    
            {
                List<string> asd = new List<string>();
                string str = "I shall give her what she deserves aeserves";
                string[] words = str.Split(new[] { " " }, StringSplitOptions.None);     // str stringdeki cümlesindeki kelimeleri array'a atar. boşluk görürse kesip sonraki indekse geçer.
                string word = "";
                int ctr = 0;
                foreach (String item in words)      
                {


                    
                    if (item.Length > ctr)
                    {

                        word = item;        //ilk kelime ctr büyükse sakla o kelimenin uzunluğunu sakla. bir sonraki kelimeyle karşılaştır. Bir sonraki kelime daha büyükse değiştir.
                        ctr = item.Length;

                    }
                }

                foreach(String item in words)
                {
                    if(item.Length >= ctr)
                    {
                        asd.Add(item);
                    }
                }
                foreach (var item in asd)
                {
                    Console.WriteLine(item);            //ikinci taramada kelimedeki harf sayısı eşit olanları list'e ekle.
                }
            }
        }

        public class test
        {
            public static void abs()
            {
                int a = -12;
                
                Console.WriteLine(Math.Abs(a));
            }

            }

    }
}
