using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the numbers and press Return:");
            string userValue = Console.ReadLine();

            ConsoleColor ccForegroundColor = Console.ForegroundColor;
            if (userValue == "4 8 15 16 23 42")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Recalibrating energy core ... Complete.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FAILURE!");
                Console.Beep();
            }

            Console.ForegroundColor = ccForegroundColor;
            Console.ReadLine();
        }
    }
}
