using System;

namespace Isp.Vehicles
{
    class Car : IVehicleCar
    {
        private string Color;
        private int Year;
        private double Engine;
        private int Seats;
        private int Doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this.Color = color;
            this.Year = year;
            this.Engine = engine;
            this.Seats = seats;
            this.Doors = doors;

            Console.WriteLine("Criando carro");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores");
        }
    }
}
