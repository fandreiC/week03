using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Part02
{
    class HW0301RMK
    {
        public static void ShowScreen()
        {
            Console.Clear();
            //app05();
            app09();
            app05();

            Program.RestartMenu();
        }
        static LinkedList<int> createRNDLinkedList(LinkedList<int> lista, int size,int maxValue)
        {
            Random rnd = new Random();
            LinkedList<int> listaa = new LinkedList<int>();
            lista = listaa;
            for (int i = 0; i < size; i++)
                lista.AddLast(rnd.Next(maxValue));
            Console.WriteLine("LinkedList RND este: [{0}]", String.Join(",", lista));
            return lista;

        }
        static LinkedList<int> orderLinkedList(LinkedList<int> lista)
        {
            lista = new LinkedList<int>(lista.OrderBy(x => x));
            Console.WriteLine("LinkedList In Order: [{0}]", String.Join(",", lista));
            return lista;
        }
        static LinkedList<int> CreateOrderedList(int size,int maxValue)
        {

            LinkedList<int> list = new LinkedList<int>();
            list = createRNDLinkedList(list, size,maxValue);
            list = orderLinkedList(list);
            return list;
        }
        static LinkedList<int> removeDuplicatesFromList(LinkedList<int> lista)
        {
            LinkedListNode<int> nod = lista.First;
            while (nod.Next != null)
            {
                var urmatorul = nod.Next;
                if (nod.Value == nod.Next.Value)
                {
                    lista.Remove(nod);
                }
                nod = urmatorul;                
            }
            return lista;
            
        }
        static void app05()
        {
            int size = 20,max=20;
            Console.WriteLine("\nRemove duplicates from sorted linked list :\n");
            LinkedList<int> list = CreateOrderedList(size,max);
            list=removeDuplicatesFromList(list);
            afisareLista(list);


        }
        static void mergeTwoSortedLinkedListEasy(LinkedList<int> lista1, LinkedList<int> lista2)
        {
            lista1 = new LinkedList<int>(lista1.Union(lista2).OrderBy(x => x));
            Console.WriteLine("LinkedList toghether:[{0}]", String.Join(",", lista1));
        }
       
        static LinkedList<int> mergeTwoSortedLinkedList(LinkedList<int> lista1, LinkedList<int> lista2)
        {
            LinkedList<int> lista3 = new LinkedList<int>();

            LinkedListNode<int> node1 = lista1.First;
            LinkedListNode<int> node2 = lista2.First;
            bool a = true;

            do
            {


                if (node1.Value < node2.Value)
                {
                    lista3.AddLast(node1.Value);
                    node1 = node1.Next;

                }
                else
                {
                    lista3.AddLast(node2.Value);
                    node2 = node2.Next;
                }

                if (node1 == null || node2 == null)
                    a = false;
                Console.WriteLine(" Steps: "+ String.Join(" ", lista3));

            } while (a);

            if (node1 == null)
            {
                do
                {
                    lista3.AddLast(node2.Value);
                    node2 = node2.Next;
                } while (node2 != null);
            }
            else if (node2 == null)
            {
                do
                {
                    lista3.AddLast(node1.Value);
                    node1 = node1.Next;
                } while (node1 != null);
            }
            return lista3;

        }
        static void afisareLista(LinkedList<int> lista)
        {
            Console.WriteLine("\nLista              : [{0}]", String.Join(".", lista));
        }
        static void app09()
        {
            Console.WriteLine("\napp09 How to merge two sorted linked list, write a program in your favorite programming language e.g. Java, C#\n");
            int size = 14,max=66;

            LinkedList<int> list1 = CreateOrderedList(size,max);
            LinkedList<int> list2 = CreateOrderedList((size + 5),max);
            // LinkedList<int> lista3 = CreateOrderedList(size);
            // LinkedList<int> lista4 = CreateOrderedList(size);
            // LinkedList<int> lista5 = CreateOrderedList(size);

            //LinkedList<int> lista6 = new LinkedList<int>();
            //   createRNDLinkedList(lista6,size-5);

            afisareLista(list1);
            afisareLista(list2);

            mergeTwoSortedLinkedListEasy(list1, list2);
           
            list1 = mergeTwoSortedLinkedList(list1,list2);
            afisareLista(list1);
            removeDuplicatesFromList(list1);
            afisareLista(list1);
            
           

        }


    }
}
