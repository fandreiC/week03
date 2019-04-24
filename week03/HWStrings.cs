using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week03
{
    class HWStrings
    {
        public static void ShowScreen()
        {
            Console.Clear();
            app10();
            app13();

            Program.Restart();
        }
        static string verificareString(string text)
        {
            Console.Write($" << {text} >> ");
            text.Trim();
            char[] t = text.ToLower().ToCharArray();
            Array.Sort(t);
            string backText = new string(t);
            return backText;
        }
        static void verificareString(string unText,string altText)
        {
            Console.Write("\nCheck text {0} & {1} : ", unText, altText);
            if (unText==altText) Console.Write(" Yes"); else Console.Write(" NO");
        }
        private static void app10()
        {
            Console.WriteLine("\nApp10 Write a Program which checks if two Strings are Anagram or not?");
            string text1 = " Andrei ",text2="  5 ",text3="1abc ",text4=" bc1a";
           text1 = verificareString(text1);
            text2 = verificareString(text2);
            text3 = verificareString(text3);
            text4 = verificareString(text4);
            verificareString(text1, text2);
            verificareString(text3, text4);
            verificareString(text1, text3);
            verificareString(text2, text4);




        }

        static void verificareDuplicate(string text)
        {
            //string textNou = string.Join(" ",text.ToCharArray().Distinct());
            string textNou = string.Join(" ",text.Distinct());
            Console.WriteLine($" <<{textNou}>>");
        }
        static void aranjareString(string text)
        {
            Console.WriteLine($" <<{text}>>");
            text.Trim();
        }
        private static void app13()
        {
            Console.WriteLine("\n\nApp13 Write a function to remove duplicate characters from String?");
            string text1 = "   www.Google.com ",text2=" asdfgh";

            aranjareString(text1);
            aranjareString(text2);

            verificareDuplicate(text1);
            verificareDuplicate(text2);
        }
       

    }
}
