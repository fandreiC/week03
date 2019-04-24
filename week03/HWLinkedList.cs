using System;
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
            app05();
            app08();
            app09();
            app14();
            app18();
        }

        private static void app05()
        {
            Console.WriteLine("\nRemove duplicates from sorted linked list :");
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(4);
            list.AddLast(7);
            list.AddLast(7);
            list.AddLast(8);
            //Console.WriteLine(" "+ list.Distinct());
            // LinkedListNode<int> firstNode = new LinkedListNode<int>(4);
            foreach (var elem in list)
            {
                Console.Write(" " + elem);
            }
            while (true)
            {

            }


        }
        public static void app08()
        {
            Console.WriteLine("\napp08 How to detect a cycle in a singly linked list?");

        }
        public static void app09()
        {
            Console.WriteLine("\napp09 How to merge two sorted linked list, write a program in your favorite programming language e.g. Java, C#");

        }
        public static void app14()
        {
            Console.WriteLine("\napp14 How to find the 3rd element from the end, in a singly linked, in a single pass?");

        }
        public static void app18()
        {
            Console.WriteLine("\napp18 Write code to reverse a linked list, if you able to do it using loops, try to solve with recursion?");

        }

    }
}
