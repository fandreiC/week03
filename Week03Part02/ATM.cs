using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Part02
{
    class ATM
    {
        public static void ShowScreen()
        {
            bool passPin;
            int cashValue = 5000;
            passPin = checkPin();
            if (passPin)
            {
                transactionsScreen(ref cashValue);

            }
            else
            {
                Console.WriteLine("\n ATM transactions display ENDED - goodbye !");
                Console.ReadKey();
                
            }

            Program.RestartMenu();
        }
        static bool checkPin()
        {
            int pin, attempts = 5;
            bool a;
            do
            {
                a = true;
                //Console.Clear();
                Console.WriteLine("\n Pentru ANULARE introduceti 0(ZERO) ");
                Console.WriteLine("Enter your pin : ( 4 DIGITS LONG & 1st != 0 ) ");
                a = int.TryParse(Console.ReadLine(), out pin);
                if (pin == 0)
                    return false;
                if (pin < 1000 || pin > 9999)
                    a = false;
                attempts--;
                if (attempts == 0)
                {
                    Console.WriteLine("Only 5 attempts of inserting pin ! Card was BLOCKED !");
                    Console.ReadKey();
                    return false;
                }
            } while (!a);
            Console.WriteLine("\n PIN ok !");
            Console.ReadKey();
            return true;

        }
        static int checkOption()
        {
            int option;
            bool a = true;
            do
            {
                Console.Clear();
                Console.WriteLine(@" Wellcome to ATM transaction display 
               ATM ATM ATM ATM ATM ATM ATM ATM  The types of ATM transaction are
                1) Balance checking
                2) Cash withdrawal
                3) Cash deposition. 
                4) QUIT ATM display     4- EXIT -4
                Choose any of the above transaction ");
                a = int.TryParse(Console.ReadLine(), out option);
                if (option < 1 || option > 4)
                {
                    a = false;
                    Console.WriteLine("option not available");
                }

            } while (!a);
            return option;
        }

        static void doOption(int option, ref int cashValue)
        {

            switch (option)
            {
                case 1:
                    doBalanceCheck(ref cashValue);
                    break;
                case 2:
                    doRetragereCash(ref cashValue);
                    break;
                case 3: doDepunereCash(ref cashValue);
                    break;
                case 4: return;
            }
        }
        static void transactionsScreen(ref int cashValuee)
        {
            int option;


            option = checkOption();
            doOption(option, ref cashValuee);


        }
        static void doBalanceCheck(ref int cashValuee)
        {
            Console.WriteLine($"\n You have in account: {cashValuee}$ ");
            Console.ReadKey();
            transactionsScreen(ref cashValuee);
        }
        static void doRetragereCash(ref int cashValuee)
        {
            int cashOut;
            Console.WriteLine("\n Pentru ANULARE introduceti 0(ZERO) ");
            Console.WriteLine("\n Introduceti suma de retras : ( BANCNOTA MINIMA ESTE  10$) ");

            bool a = true, anulare = false; ;
            do
            {
                a = int.TryParse(Console.ReadLine(), out cashOut);
                if (cashOut == 0)
                {
                    anulare = true;
                    goto ReturnTOtop;
                }
                if (cashOut % 10 != 0)
                {
                    Console.WriteLine("\n BANCNOTA MINIMA din ATM ESTE  10$ , reincercati :");
                    a = false;
                }
                if (cashOut > cashValuee)
                {
                    Console.WriteLine("\n Nu aveti fonduri suficiente !");
                    //a = true;
                    goto ReturnTOtop;
                }
            } while (!a);

            cashValuee -= cashOut;
            Console.WriteLine($"Ati retras {cashOut}$ ! mai aveti in cont {cashValuee}");

        ReturnTOtop:
            Console.ReadKey();
            transactionsScreen(ref cashValuee);
        }
        static void doDepunereCash(ref int cashVal)
        {
            bool a;
            int cashIn;
            Console.WriteLine("\n Introduceti suma pe care o depuneti: ");
            a = int.TryParse(Console.ReadLine(),out cashIn);
            cashVal += cashIn;
            Console.WriteLine("\n Noul sold este : "+cashVal);

            Console.ReadKey();
            transactionsScreen(ref cashVal);
        }

    }
}
