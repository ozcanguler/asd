using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SkylineFormat
    {
        String name = "Hello World";
        //String staggeredLetters = citySkyline(name);
        int leng;
        List<string> listt = new List<string>();
        
        
        //public string len(string ss)
        //{
        //    ss = name.Length.ToString();
        //    return ss;
        //}
        public int lens()
        {
            leng = name.Length;
            return leng;
            
        }
        public void showFirstName()
        {
            Console.WriteLine(name);
        }
        public  void UpperAndLower()
        {
            for (int i = 0; i < lens(); i++)
            {
                if (i % 2 == 0)
                {
                    listt.Add(name.Substring(i, 1).ToUpper());
                }
                else
                {
                    listt.Add(name.Substring(i, 1).ToLower());
                }
               
            }          

            foreach (var item in listt)
            {
                Console.Write(item);
            }

        }

    }
}
