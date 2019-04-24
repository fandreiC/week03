using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace week03
{
    class HWArrays
    {
        public static void ShowScreen()
        {
            Stopwatch arrayTimer = new Stopwatch();
            arrayTimer.Start();
            Console.Clear();
            app01();
            app02();
            app04();
            app07();
            app19();
            app20();
            app21();
            arrayTimer.Stop();
            Console.WriteLine("\n Elapsed  time with arrays: "+arrayTimer.Elapsed);
            Program.Restart();
        }

        private static int[] CreateRndArray(int size, int minValue, int maxValue)
        {
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(minValue, maxValue);
                // Console.Write(" " + arr[i]);
            }
            Console.WriteLine("Array is:        [{0}]", string.Join(",", arr));
            return arr;
        }
        public static void app01()
        {
            Console.WriteLine("\napp01: Given an array of ints, write a C# method to total all the values that are even number.\n sirul este: ");
            int[] array = new[] { 10, 23, 12, 44, 13, 44, 12 };
            int sum = 0;
            foreach (var elem in array)
            {
                if (!(elem % 2 == 0))
                    sum += elem;
                Console.Write(" " + elem);
            }
            Console.WriteLine("   suma numerelor impare:  " + sum);
        }
        public static void app02()
        {
            Console.WriteLine("\napp02: How to find all pairs of elements in an integer array, whose sum is equal to a given number?");
            Random rnd = new Random();
            //int sum = rnd.Next(10,20);
            int sum = 15;
            //int[] arr1 = new int[20];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = rnd.Next(15);
            //    Console.Write(" "+arr1[i]);
            //}

            int[] arr1;
            arr1 = CreateRndArray(20, 0, 15);

            Console.WriteLine("\n");
            for (int i = 0; i < arr1.Length; i++)
            {

                for (int j = i; j < arr1.Length; j++)
                {
                    if (sum == (arr1[i] + arr1[j]))
                        Console.WriteLine(" {0} = {1} + {2}", sum, arr1[i], arr1[j]);

                }
            }

        }
        private static void app04()
        {
            Console.WriteLine(" \napp04: Algorithm to find if Array contains duplicates? ");
            //int[] arr1 = new int[50];
            bool a = true;
            Random rnd = new Random();
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = rnd.Next(15);
            //    Console.Write(" "+arr1[i]);
            //}
            int[] arr1;
            arr1 = CreateRndArray(15, 0, 15);

            for (int i = 0; i < arr1.Length; i++)//foreach (var item1 in arr1)
            {
                for (int j = 0; j < arr1.Length; j++)//foreach (var item2 in arr1)
                {
                    if ((arr1[i] == arr1[j]) && (i != j))
                    {
                        a = false;
                        break;
                    }
                }
                if (!a)
                {
                    Console.WriteLine("\nArray has duplicates ! one of them is :" + arr1[i]);
                    return;
                }
            }
            Console.WriteLine("\nArray has only unique values!");
        }

        private static void app07()
        {
            Console.WriteLine("\nApp07 Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?");
            int[] arr7 = CreateRndArray(40, 5, 10);
            int nrAparitii = 0, nr = 0;
            for (int i = 0; i < arr7.Length; i++)
            {
                int aparitii = 0;
                for (int j = i; j < arr7.Length; j++)
                {
                    if (arr7[i] == arr7[j])
                    {
                        aparitii++;
                    }
                }
                if (aparitii > nrAparitii)
                {
                    nr = arr7[i];
                    nrAparitii = aparitii;
                }
            }
            decimal procentAparitii = ((decimal)nrAparitii / arr7.Length) * 100;
            Console.WriteLine("\n Nr cu cele mai multe apartitii ({1}) este {0} , procentual :{2}% din numarul total de elemente ({3}) ", nr, nrAparitii, procentAparitii, arr7.Length);


        }
        private static void app19()
        {
            Console.WriteLine("\nApp19 How to rotate an array by a given pivot?");
            int[] arr19 = CreateRndArray(20, 0, 15), temparr = new int[20];

            int pivot = 4;
            for (int i = 0; i < pivot; i++)
            {
                temparr[i] = arr19[i];
            }
            for (int i = 0; i < (arr19.Length - pivot); i++)
            {
                arr19[i] = arr19[i + pivot];
            }
            int j = 0;
            for (int i = (arr19.Length - pivot); i < arr19.Length; i++)
            {
                arr19[i] = temparr[j++];
            }
            Console.WriteLine("\n Pivot = {0}! New array is: [{1}]", pivot, string.Join(",", arr19));


        }
        private static void app20()
        {
            Console.WriteLine("\nApp20 Sorting an Array using Selection Sort");
            int[] arr20 = CreateRndArray(30, 0, 20);
            for (int i = 0; i < arr20.Length; i++)
            {
                int min = arr20[i], temp, tempIndex = i;
                for (int j = i; j < arr20.Length; j++)
                {
                    if (arr20[j] < min)
                    {
                        min = arr20[j];
                        tempIndex = j;
                    }
                }
                temp = arr20[i];
                arr20[i] = min;
                arr20[tempIndex] = temp;
            }
            Console.WriteLine("\nSorted Array is: [{0}]", string.Join(",", arr20));

        }
        private static void app21()
        {
            Console.WriteLine("\nApp21 Sorting an Array using Bubble Sort");
            int[] arr21 = CreateRndArray(30, 0, 30);
            for (int i = 0; i < arr21.Length - 1; i++)
            {
                for (int j = 0; j < arr21.Length - 1; j++)
                {
                    if (arr21[j] > arr21[j + 1])
                    {
                        arr21[j] += arr21[j + 1];
                        arr21[j + 1] = arr21[j] - arr21[j + 1];
                        arr21[j] = arr21[j] - arr21[j + 1];
                    }
                }
            }
            Console.WriteLine("\nSorted Array is: [{0}]", string.Join(",", arr21));

        }

    }
}
