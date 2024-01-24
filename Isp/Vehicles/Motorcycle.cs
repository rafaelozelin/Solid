using System;

namespace Isp.Vehicles
{
    class Motorcycle : IVehicleMotorcycle
    {
        private string Color;
        private int Year;
        private double Engine;

        public Motorcycle(string color, int year, double engine)
        {
           ConfigureMotorcycle(color, year, engine);
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            this.Color = color;
            this.Year = year;
            this.Engine = engine;

            Console.WriteLine("Criando moto");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores");
        }
    }
}
