using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class swapLetters
    {
      public  String sentence = "Our greatest glory is not in never falling, but in rising every time we fall.";

        //public String endingString = "";
        char[] endingString;    

        public void convert()
        {
            endingString = sentence.ToCharArray();
        }
        public void listCharacter()
        {         
            //sentence=  sentemce.Replace("e", "#");
            //  sentence = sentemce.Replace("u", "^");
            //  sentence = sentemce.Replace("o", "Ø");
            //  sentence = sentemce.Replace("a", "@");
            //  sentence = sentemce.Replace("i", "!");

            var dict = new Dictionary<char, char>();
            dict.Add('e', '#');
            dict.Add('u', '^');
            dict.Add('o', 'Ø');
            dict.Add('a', '@');
            dict.Add('i', '!');

            Console.WriteLine("Here is the list of character substitutions");
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(sentence);
            for (int i = 0; i < sentence.Length; i++)
            {
                //if (dict.ContainsKey(sentence[i]))
                //{
                //    endingString += dict[sentence[i]];
                //}
                //else
                //{
                //    endingString += sentence[i];
                //}
                if (dict.ContainsKey(sentence[i]))
                {
                    endingString[i] = dict[sentence[i]];
                }
               
            }
            Console.WriteLine(endingString);
        }
    }
}
