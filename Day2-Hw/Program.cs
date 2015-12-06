using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader Reader = new StreamReader("decryptme.txt");
            StreamWriter Writer = new StreamWriter("newinput.txt");
            string line = string.Empty;


            while (line != null)
            {
                line = Reader.ReadLine();
                if (line != null)
                {
                    char[] array = line.ToCharArray();
                    Array.Reverse(array);
                    Console.WriteLine(array);
                    Writer.WriteLine(array);
                }
            }

            Reader.Close();
            Writer.Close();

            Console.ReadLine();
        }
    }
}
