using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Part02
{
    class LeapYear
    {
        public static void ShowScreen()
        {
            Console.Clear();
            Console.WriteLine(@" A year is leap year if the following conditions are satisfied:
                1. Year is multiple of 400.
                2. Year is multiple of 4 and not multiple of 100.
                3. Program will check 4 random years between 1  - 99.000");

            AppYear();

            Program.RestartMenu();
        }
        static void LeapYearCheck(int yearToCheck)
        {
            bool a =false;
            if ((yearToCheck % 4 == 0 && yearToCheck % 100 != 0) || yearToCheck % 400 == 0)
                a = true;
                Console.WriteLine(a ? " Y:{0} IS A LEAP YEAR" : "Y:{0} is Not leap Year",yearToCheck);
        }
        static void AppYear()
        {
            Random rnd = new Random();
            int n = 4;
            do
            {
                int y = rnd.Next(1, 99000);
                LeapYearCheck(y);
                n--;
            } while (n>0);

        }
    }
}
