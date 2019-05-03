using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week03
{
    class HWLinkedList
    {
        public static void ShowScreen()
        {
            app00();
            app05();
            //app08();
            app09();
            app14();
            app18();
        }

        static LinkedList<int> CreateRndList(LinkedList<int> lista, int size, int minValue, int maxValue)
        {
            Random rnd = new Random();

            lista.AddFirst(7);
            do
            {
                lista.AddLast(rnd.Next(minValue, maxValue));
                size--;

            } while (size > 0);
            //lista.AddFirst(9);
            //lista.AddLast(0);
            //lista.AddFirst(7);
            //lista.AddLast(4);
            //lista.AddLast(7);
            //lista.AddLast(8);
            //lista.AddFirst(5);
            return lista;
        }
        static void afisareLista(LinkedList<int> lista)
        {
            foreach (var elem in lista)
            {
                Console.Write(" " + elem);
            }
            Console.WriteLine(" ,list count:{0}, First node: {1} , Last node: {2}", lista.Count, lista.First.Value, lista.Last.Value);
            Console.WriteLine("\nList contains 7 ? :{0}", lista.Contains(7));
        }
        static void afisareLista2(LinkedList<int> lista)
        {
            LinkedList<int>.Enumerator en = lista.GetEnumerator();
            while (en.MoveNext())
            {
                Console.Write(" " + en.Current);
            }

        }

        private static void app00()
        {
            Console.WriteLine("\nFew Linked Lists :");
            LinkedList<int> list = new LinkedList<int>();
            int size = 8, min = 0, max = 18;
            list = CreateRndList(list, size - 1, min, max);
            afisareLista(list);

            LinkedListNode<int> nod = list.Find(7);
            list.AddAfter(nod, 33);
            list.RemoveFirst();
            list.Remove(61);
            afisareLista2(list);


            SortedList slist = new SortedList();
            slist = createSortedList(slist);

        }

        static SortedList createSortedList(SortedList lista)
        {

            Console.WriteLine(" \nSorted List : count {0} ", lista.Count);
            lista.Add(3, "want");
            lista.Add(4, "some");
            lista.Add(7, "some");
            lista.Add(6, "text");
            lista.Add(8, "text");
            lista.Add(5, "other");
            lista.Add(1, "next");
            // list.RemoveAt(3);//index
            //list.Remove(2);//key
            foreach (DictionaryEntry pair in lista)
            {
                Console.WriteLine(" key- {0} has Value- {1} ", pair.Key, pair.Value);
            }
            Console.WriteLine(" Sorted List : count {0} ", lista.Count);
            return lista;
        }
        static SortedList createSortedList(SortedList lista, int size, int minValue, int maxValue)
        {
            Random rnd = new Random();
            int i = 1, x = 7, a = minValue; ;
            do
            {
                if (x < 1) x = 1;
                a = rnd.Next(a, maxValue / x); x--;
                lista.Add(i, a);
                size--; i++;
            } while (size > 0);
            foreach (DictionaryEntry pair in lista)
            {
                Console.WriteLine("  key- {0} has Value- {1} ", pair.Key, pair.Value);
            }
            return lista;
        }
        static LinkedList<int> createSortedList(LinkedList<int> lista, int size)
        {
            Random rnd = new Random();

            for (int i = 0; i <= size; i++)
            {
                lista.AddLast(rnd.Next(100));

            }
            foreach (var item in lista)
                Console.Write(" " + item);
            Console.WriteLine("");


            return lista;
        }
        static void mergeTwoLists()
        {
            int size1 = 10, size2 = 15;
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();
            list1 = createSortedList(list1, size1);            
            list2 = createSortedList(list2, size2);

            Console.WriteLine("merged lists : ");
            list1 = new LinkedList<int>(list1.Union(list2).OrderBy(x=>x));
            foreach(var item in list1)
                Console.Write(" "+item);
            
        }
        static void app05()
        {
            Console.WriteLine("\nRemove duplicates from sorted linked list :");
            int size = 10, min = 1, max = 15;
            SortedList slist = new SortedList();
            slist = createSortedList(slist, size, min, max);
            Console.WriteLine("\n ..................\n");
            LinkedList<int> listas = new LinkedList<int>();
            listas = createSortedList(listas,size);
            listas = new LinkedList<int>(listas.OrderBy(x => x));
            foreach (var item in listas)
                Console.Write(" "+item);
            Console.WriteLine();
            
            
        }
        public static void app08()
        {
            Console.WriteLine("\napp08 How to detect a cycle in a singly linked list?");

        }
        public static void app09()
        {
            Console.WriteLine("\napp09 How to merge two sorted linked list, write a program in your favorite programming language e.g. Java, C#");
            mergeTwoLists();

        }
        public static void app14()
        {
            Console.WriteLine("\napp14 How to find the 3rd element from the end, in a singly linked, in a single pass?");
            LinkedList<int> list = new LinkedList<int>();
            list = createSortedList(list,15);
            LinkedListNode<int> endNode = list.Last;
            bool a = true;
            int b = 0;
            while (a)
            {
                b++;
                endNode = endNode.Previous;
                if (b == 2)
                {
                    Console.WriteLine("  3 RD element from tail is: {0}", endNode.Value);
                    a = false;
                }
            }

        }
        public static void app18()
        {
            Console.WriteLine("\napp18 Write code to reverse a linked list, if you able to do it using loops, try to solve with recursion?");
            LinkedList<int> listToReverse = new LinkedList<int>();
            listToReverse = createSortedList(listToReverse, 15);
            listToReverse = new LinkedList<int>(listToReverse.OrderBy(x=>x));
            Console.WriteLine("List to reverse is: ");
            foreach (var item in listToReverse)
                Console.Write(" "+item);

            LinkedList<int> listReversed = new LinkedList<int>();
            LinkedListNode<int> start = listToReverse.Last;

            while (start!=null)
            {
                listReversed.AddLast(start.Value);
                start = start.Previous;
            }
            Console.WriteLine(" \n:::: Reversed is :");
            foreach (var item in listReversed)
            {
                Console.Write(" "+item);
            }

        }

    }
}
