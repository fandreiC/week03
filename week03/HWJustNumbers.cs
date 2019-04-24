using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week03
{
    class HWJustNumbers
    {
        public static void ShowScreen()
        {
            Console.Clear();
            app03();
            app06();
            app11();
            app12();
            app15();
            app16();
            app17();

            Program.Restart();

        }
        static void factorialNormal(int nr)
        {
            long factorial = 1;
            for (int i = 1; i <= nr; i++)
            {
                factorial = factorial * i;
                Console.Write(" + " + factorial);
            }
            Console.WriteLine($"\n Factorial of {nr} is: {factorial}");
        }
        static long factorialRecursiv(int nr)
        {
            if (nr == 0)
                return 1;
            
            return nr * factorialRecursiv(nr-1);
        }
        private static void app03()
        {
            Console.WriteLine("\napp03 How to calculate factorial using recursion in C# + iterative + time difference.");
            int nr = 6;
            factorialNormal(nr);

            long factorial = factorialRecursiv(nr);
            Console.WriteLine($"\n Recursiv : factorial of {nr} is: {factorial}");
        }
        static int sumaCifrelor(int nr)
        {
            int sum = 0;
            do
            {
                sum += nr % 10;
                nr /= 10;
            } while ((nr%10)!=0);
            return sum;
        }
        static int sumaCifrelorRecursiv(int nr)
        {
            if (nr != 0)
                return (nr % 10 + sumaCifrelorRecursiv(nr / 10));
            else
                return 0;
        }
        private static void app06()
        {
            Console.WriteLine("\nApp06 How to find sum of digits of a number using Recursion?");
            int nr = 4567;
            Console.WriteLine($"\n Suma ciferlor lui {nr} este : {sumaCifrelor(nr)}");
            Console.WriteLine($"\n Recursiv suma ciferlor lui {nr} este : {sumaCifrelorRecursiv(nr)}");

        }
        private static void app11()
        {
            Console.WriteLine("\nApp11 Write a function to print the nth number in Fibonacci series?");
            int nr = 20;
            long primul =0,urmatorul=1,temp=0;
            Console.Write($" {primul}, {urmatorul}, ");
            for (int i = 2; i < nr; i++)
            {
                temp = primul + urmatorul;
                Console.Write($" {temp},");
                primul = urmatorul;
                urmatorul = temp;
            }

        }
        private static void app12()
        {
            Console.WriteLine("\n\nApp12 Write a function to count a total number of set bits in a 32-bit Integer?");
            int nr = 60,count=0;
            char t = 'a';
            Console.WriteLine(" bits: "+(char)nr+" , " +(int)t+"\n");
            string a = Convert.ToString(nr, 2).PadLeft(32, '0');
          
            Console.WriteLine("\nstring convert of {0} : {1}", nr, a);
            while (nr>0)
            {
                Console.Write(" , "+nr);
                count += nr & 1;
                nr= nr>>1;
            }
            Console.WriteLine("    Nr de set biti : "+count);
       

        }
        static void armstrongCheck(int nr)
        {
            int sum = 0, cifra, temp = nr;
            while (temp > 0)
            {
                cifra = temp % 10;
                sum += (cifra * cifra * cifra);
                temp = temp / 10;
            }
            if (nr == sum)
                Console.WriteLine($"\nNumarul {nr} este Armstrong");
            else
                Console.WriteLine($"\nNumarul {nr} NU este Armstrong");
        }
        private static void app15()
        {
            Console.WriteLine("\nApp15 C# program to check if a number is Armstrong number or not?");
            for (int i = 369 ; i < 375; i++)
            {
                armstrongCheck(i);
            }
        }
        static void primeCheck(int nr)
        {

            int count = 0;
            for (int i = 1; i < nr; i++)
            {
                if (nr % i == 0)
                    count++;
            }
            if(count==1)
                Console.WriteLine($"\n Numarul {nr} este prim");
        }
        private static void app16()
        {
            Console.WriteLine("\nApp16 Algorithm to check if a number is Prime or not?");
            int nr = 30;
            for (int i = 0; i < nr; i++)
            {
                primeCheck(i);
            }
            
        }
        static void palindromeCheck(int nr)
        {
            int sum = 0,cifra,temp=nr;
            while (temp>0)
            {
                cifra = temp % 10;
                sum = (sum * 10) + cifra;
                temp = temp / 10;
            }
            if(sum==nr)
                Console.WriteLine("\n Numarul {0} este palindrom",nr);
            else
                Console.WriteLine("\n Numarul {0} NU este palindrom", nr);
        }
        private static void app17()
        {
            Console.WriteLine("\nApp17 Algorithm to check if a number is a Palindrome?");
            int nr = 1221;
            palindromeCheck(nr);

        }

    }
}
