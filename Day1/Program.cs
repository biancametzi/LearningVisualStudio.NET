using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?");
            var userValue = Console.ReadLine();

            var message = string.Empty;
            switch (userValue)
            {
                case "1":
                    message = "You won a car!";
                    break;
                case "2":
                    message = "You won a boat!";
                    break;
                case "3":
                    message = "You won a cat!";
                    break;
                default:
                    message = "We didn't understand. You lose!";
                    break;
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }

}
