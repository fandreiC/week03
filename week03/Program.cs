using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace week03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Afisare();

            Console.WriteLine("\nBye Bye !");
            Console.ReadKey();
        }
        static void Afisare()
        {
            Console.Clear();
            Console.WriteLine("Wellcome :\n");

            bool check;
            int opt;
            do
            {
                Console.WriteLine(@"Options are: 
                1. Numbers Exercises
                2. Strings Exercises
                3. Arrays Exercises
                4. LinkedLists Exercises
                0. Exit Program");
                check = int.TryParse(Console.ReadLine(),out opt);
                if(opt<0 ||opt > 4)
                {
                    check = false;
                    Console.WriteLine("\n Just 4 options ...");
                }

            } while (!check);
            switch (opt)
            {
                case 1: HWJustNumbers.ShowScreen();
                    break;
                case 2: HWStrings.ShowScreen();
                    break;
                case 3: HWArrays.ShowScreen();
                    break; ;
                case 4: HWLinkedList.ShowScreen();
                    break;
                case 0:return;
                   
            }
          

            
        }
        internal static void Restart()
        {
            Console.WriteLine("\nBye Bye !");
            Console.ReadKey();
            Afisare();
        }
    }
}
