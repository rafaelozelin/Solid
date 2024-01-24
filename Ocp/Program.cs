using Ocp.Vehicle;
using System;

namespace Ocp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = TypeVenicle.CAR;

            if(type == TypeVenicle.CAR)
            {
                var car = new Car("Azul", 2000, 2.0, 5, 4);
            }
            else
            {
                var motocycle = new Motocycle("Branco", 2023, 2.0);
            }

            Console.ReadLine();
        }
    }
}
