using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto myCar = new Auto();
            myCar.Speed = 0;
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1988;
            myCar.Color = "Silver";
            myCar.Miles = 50000;


            Console.WriteLine(myCar.Make + " " + myCar.Model);

            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Decelerate();

            Console.WriteLine("My current speed: " + myCar.Speed);

            Console.ReadLine();
        }
    }
}
