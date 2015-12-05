using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] numbers = new int[5];
             numbers[0] = 4;
             numbers[1] = 8;
             numbers[2] = 15;
             numbers[3] = 16;
             numbers[4] = 23;
             */

            int[] numbers = { 4, 8, 15, 16, 23 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i].ToString());
            }

            string[] names = { "Bob", "Bogdan", "Bianca" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            string myText = "Now is the time for us to go eat.";
            char[] charArray = myText.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);

            //Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
        }
    }
}
