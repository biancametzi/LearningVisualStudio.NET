using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day0_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());  // citim o linie de la tastatura si o convertim la un intreg; echivalenta mai jos
            // string line = Console.ReadLine();                // citim un string de la tastatura
            // int numberOfLines = int.Parse(line);             // convertim stringul la un numar intreg pe care il vom folosin mai jos la instructiunea 'for'

            StreamWriter sw = new StreamWriter("pisoi.txt");    // deschidem fisierul "pisoi.txt" pentru scriere (daca fisierul nu exista, el va fi creat)
            for (int i = 0; i < numberOfLines; i++)             // pentru fiecare din cele 'numberOfLines' linii ce urmeaza a fi citite de la tastatura
            {
                string line = Console.ReadLine();               // citim o linie de la tastatura
                sw.WriteLine(line);                             // scriem linia citita de la tastatura in fisierul 'pisoi.txt'
            }

            sw.Close();
        }
    }
}
