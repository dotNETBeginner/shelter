using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1_лаба_4_
{
    abstract class Tires
    {
        public double Tire1Pressure { get; set; }
        public int Tire1Age { get; set; }

        public double Tire2Pressure { get; set; }
        public int Tire2Age { get; set; }

        public double Tire3Pressure { get; set; }
        public int Tire3Age { get; set; }

        public double Tire4Pressure { get; set; }
        public int Tire4Age { get; set; }

        public Tires(double tire1Pressure,int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            Tire1Pressure = tire1Pressure;
            Tire1Age = tire1Age;

            Tire2Pressure = tire2Pressure;
            Tire2Age = tire2Age;

            Tire3Pressure = tire1Pressure;
            Tire3Age = tire1Age;

            Tire4Pressure = tire1Pressure;
            Tire4Age = tire1Age;
        }

    }
     abstract class Cargo : Tires
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

        public Cargo(int cargoWeight, string cargoType, double tire1Pressure,int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure,
            int tire3Age, double tire4Pressure, int tire4Age)
            :base(tire1Pressure,tire1Age,tire2Pressure,tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

    }
     abstract class Engine : Cargo
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(int engineSpeed, int enginePower, int cargoWeight, string cargoType,double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure,
            int tire3Age, double tire4Pressure, int tire4Age)
            :base(cargoWeight, cargoType,tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }
    }
     class Car:Engine
    {
        public string Model { get; set; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure,
            int tire3Age, double tire4Pressure, int tire4Age)
            : base(engineSpeed, enginePower, cargoWeight, cargoType,tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age)
        {
            Model = model;
        }
        public  double fineAllTiresPressure()
        {
            double val = (Tire1Pressure + Tire2Pressure + Tire3Pressure + Tire4Pressure)/4;
            return val;
        }
    }

}
