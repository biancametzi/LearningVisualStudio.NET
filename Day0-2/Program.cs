using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day0_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());      // citim un intreg de la tastatura 

            string[] arrayOfStrings = new string[numberOfLines];    // cream un sir (array) de stringuri de dimensiune 'numberOfLines'
            for (int i = 0; i < numberOfLines; i++)                 // pentru toate liniile ce urmeaza a fi citite
            {
                arrayOfStrings[i] = Console.ReadLine();             // citim liniile de la consola si le stocam/salvam in array-ul 'arrayOfStrings'
            }

            Array.Reverse(arrayOfStrings);                          // intoarcem array-ul 'arrayOfStrings'
            StreamWriter sw = new StreamWriter("pisoi.txt");        // deschidem fisirul 'pisoi.txt' pentru scriere
            for (int i = 0; i < numberOfLines; i++)                 // pentru toate liniile ce le-am citit de la tastatura/consola
            {
                sw.WriteLine(arrayOfStrings[i]);                    // scriem in fisierul 'pisoi.txt' arrayOfStrings
            }

            sw.Close();                                             // inchidem fisierul 'pisoi.txt'
            Console.ReadLine();                                     // asteptam ca utilizatorul sa inchida consola
        }
    }
}
