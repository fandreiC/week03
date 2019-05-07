using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Part02
{
    class Program
    {
        static void Main(string[] args)
        {
            Afisare();

            Console.WriteLine("\n MM:):):) End :):):) ");
            Console.ReadKey();
        }
        static void Afisare()
        {
            Console.Clear();
            Console.WriteLine(" :):):) Wellcome :):):)\n ");

            bool check;
            int opt;
            do
            {
                Console.WriteLine(@"Options are: 
                1. Entered Year is a Leap Year or Not
                2. Display the ATM Transaction
                3. Add two numbers in a file
                4. Updates of last homework
                0. Exit Program !");
                check = int.TryParse(Console.ReadLine(),out opt);
                if (opt<0 || opt > 4)
                {
                    check = false;
                    Console.WriteLine("\n Only few options !");
                }

            } while (!check);

            switch (opt)
            {
                case 0: return;
                case 1:LeapYear.ShowScreen();
                    break;
                case 2: ATM.ShowScreen();
                    break;
                case 3: textFile.ShowScreen();
                    break;
                case 4:HW0301RMK.ShowScreen();
                    break;
            }
        }
        public static void RestartMenu()
        {
            Console.WriteLine("\n :):):) End :):):) ");
            Console.ReadKey();
            Afisare();
        }

    }
}
