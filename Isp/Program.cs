using Isp.Vehicles;
using System;

namespace Isp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Azul", 2022, 4.2, 2, 2);
            var motocycle = new Motorcycle("Preto", 2022, 4.2);

            Console.ReadLine();

        }
    }
}
