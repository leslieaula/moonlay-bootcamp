using LearnCSharp.Vehicles.Interfaces;
using System;

namespace LearnCSharp.Vehicles
{
    public class Vehicle
    {
        public string Manufacture { get; set; }
        public string Type { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public DateTime StartTime { get; set; }
        public bool IsMoving { get; set; }
        public string Status { get { return IsMoving ? "Bergerak" : "Berhenti"; } }
        public DateTime StopTime { get; set; }
        public int RPM { get; set; }
        public double WheelRadius { get; set; }
        public double DistanceCovered { get; set; }

        public override string ToString()
        {
            return $"Merk: {Manufacture}\nTipe: {Type}\nJumlah Roda: {Wheels}\nJumlah Pintu: {Doors}\nUkuran Roda: {WheelRadius}\nStatus: {Status}\nWaktu Mulai Bergerak: {StartTime}\nWaktu Berhenti: {StopTime}\nKecepatan: {RPM}\nJarak Tempuh: {DistanceCovered}";
        }
    }

    public class VehicleBuilder : IMoveable<VehicleBuilder>
    {
        public VehicleBuilder() => _vehicle = new Vehicle();

        public Vehicle _vehicle { get; private set; }

        public VehicleBuilder WithManufacture(string manufacture)
        {
            _vehicle.Manufacture = manufacture;
            return this;
        }

        public VehicleBuilder WithType(string type)
        {
            _vehicle.Type = type;
            return this;
        }

        public VehicleBuilder HavingWheels(int wheels)
        {
            _vehicle.Wheels = wheels;
            return this;
        }

        public VehicleBuilder HavingDoors(int doors)
        {
            _vehicle.Doors = doors;
            return this;
        }

        public VehicleBuilder HavingWheelRadius(double wheelRadius)
        {
            _vehicle.WheelRadius = wheelRadius;
            return this;
        }

        public VehicleBuilder Move(int rpm)
        {
            _vehicle.StartTime = DateTime.Now;
            _vehicle.IsMoving = true;
            _vehicle.RPM = rpm;
            return this;
        }

        public VehicleBuilder Stop()
        {
            _vehicle.StopTime = DateTime.Now;
            _vehicle.DistanceCovered = 2 * Math.PI * _vehicle.WheelRadius * ((_vehicle.StopTime - _vehicle.StartTime).TotalSeconds * _vehicle.RPM);
            _vehicle.IsMoving = false;
            _vehicle.RPM = 0;
            return this;
        }

        public static implicit operator Vehicle(VehicleBuilder builder)
        {
            return builder._vehicle;
        }
    }

    public abstract class Creature
    {
        public abstract void Breathing();
    }

    public class Human : Creature
    {
        public override void Breathing()
        {
            Console.WriteLine("Pake Hidung");
        }
    }

    public class Plant : Creature
    {
        public override void Breathing()
        {
            Console.WriteLine("Pake Batang");
        }
    }

    public class Animal : Creature
    {
        public override void Breathing()
        {
            throw new NotImplementedException();
        }
    }
}
