using System;

namespace Ocp.Vehicle
{
    class Car : Vehicle
    {
        private int Seats;
        private int Doors;

        public Car(string color, int year, double engine, int seats, int doors): base(color, year, engine)
        {
            Seats = seats;
            Doors = doors;

            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro");
            StartVenicle();
        }
    }
}
