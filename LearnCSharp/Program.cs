using LearnCSharp.Vehicles;
using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleBuilder = new VehicleBuilder();

            //var myVar = 0;
            //myVar = "";
            //myVar = "";
            //Vehicle avanza = vehicleBuilder
            //    .WithManufacture("Toyota")
            //    .WithType("Avanza")
            //    .HavingDoors(5)
            //    .HavingWheels(4)
            //    .HavingWheelRadius(18.5);

            Vehicle avanza = vehicleBuilder
                .HavingDoors(1)
                .WithManufacture("Honda");

            //avanza.Type = "";
            //vehicleBuilder._vehicle = new Vehicle();

            Console.WriteLine(avanza);
            Console.ReadKey();
            //Console.WriteLine();

            //avanza = vehicleBuilder.Move(10);
            //Console.WriteLine(avanza);
            //Console.ReadKey();
            //Console.WriteLine();

            //avanza = vehicleBuilder.Stop();
            //Console.WriteLine(avanza);
            //Console.ReadKey();
            //Console.WriteLine();
        }
    }






}
