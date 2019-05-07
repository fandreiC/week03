using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week03_Part02
{
    class textFile
    {
        public static void ShowScreen()
        {
            Console.Clear();

            string filePathIs = "textFile1.txt";
            //textPlay();


            int[] numereleSunt = readTextFile(filePathIs);

            writeTextFile(filePathIs, numereleSunt);

            afisareTextFile(filePathIs);

            Console.ReadKey();
            Program.RestartMenu();
        }
        static void textPlay()
        {
            Console.WriteLine(" Read & Write to a File\n");
            string text = File.ReadAllText("TextFile1.txt");
            Console.WriteLine("text from file is:\n" + text);

            using (StreamReader fisier1 = new StreamReader("TextFile1.txt"))
            {
                string text2 = fisier1.ReadToEnd();
                Console.WriteLine("text2 from file is:\n" + text2);

            }
            using (StreamReader fisier2 = new StreamReader("TextFile1.txt"))
            {
                string text3;
                while ((text3 = fisier2.ReadLine()) != null)
                {
                    Console.WriteLine("text3 from file is:\n" + text3);
                }
            }
        }
        static int[] readTextFile(string filePath)
        {
            string textPeLinie;
            LinkedList<int> listaNumere = new LinkedList<int>();
            StreamReader cititor1 = new StreamReader(filePath);
            while ((textPeLinie = cititor1.ReadLine()) != null)
            {
                int numar;
                bool a;
                //numar = int.Parse(textPeLinie);
                a= int.TryParse(textPeLinie,out numar);
                listaNumere.AddLast(numar);
            }
            int[] arraydeNumere = listaNumere.ToArray();
            Console.WriteLine("Numerele Citite Din Fisier Sunt: {0}", string.Join(",", arraydeNumere));
            cititor1.Close();



            return arraydeNumere;
        }
        static void writeTextFile(string path, int[] numerele)
        {
            StreamWriter scrie = new StreamWriter(path, true);
            int suma = 0;

            foreach (int nr in numerele)
                suma += nr;
            scrie.WriteLine("Suma numerelor de mai sus este : " + suma);

            scrie.Close();
        }
        static void afisareTextFile(string file)
        {
            Console.WriteLine("\n\n Fisierul acum contine: \n");
            using (StreamReader cititor2= new StreamReader(file))
            {
                string text2 = cititor2.ReadToEnd();
                Console.WriteLine(text2);
            }
            Console.WriteLine("\n Fisierul este acum inchis !");
        }

    }
}
