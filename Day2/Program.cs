using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?");
            //string userValue = Console.ReadLine();
            //string userValue = (new Random().Next(3) + 1).ToString();
            //string message = string.Empty;
            //
            //switch (userValue)
            //{
            //    case "1":
            //        message = "You won a car!";
            //        break;
            //    case "2":
            //        message = "You won a boat!";
            //        break;
            //    case "3":
            //        message = "You won a cat!";
            //        break;
            //    default:
            //        message = "You lose!";
            //        break;
            //}
            //Console.WriteLine(message);

            for (int i = 0; i < 20; i = i + 2)
            {
                Console.WriteLine(i);
                if (i == 16)
                {
                    Console.Beep();
                    break;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
