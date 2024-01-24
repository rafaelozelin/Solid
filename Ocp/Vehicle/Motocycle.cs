using System;

namespace Ocp.Vehicle
{
    class Motocycle : Vehicle
    {
        public Motocycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotocycle();
        }

        public void ConfigureMotocycle()
        {
            Console.WriteLine($"Criando um moto");
            StartVenicle();
        }
    }
}
