using System;
using System.Collections.Generic;
using System.Text;
namespace Задание_8_лаба_3_
{
    class Car
    {
        public string Model { get; set; }
        public Car() { }

        public Car(string model)
        {

            Model = model;
        }
    }

    class Engine : Car
    {
        public Engine()
        {
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(string model, int enginespeed, int enginepower)
            :base(model)
        {
            EngineSpeed = enginespeed;
            EnginePower = enginepower;
        }
    }

    class Cargo : Engine
    {
        public Cargo() { }
        public int CargoWeight { get; set; }

        public string CargoType { get; set; }

        public Cargo(string model, int enginespeed, int enginepower,int cargoweight,string cargotype)
            :base(model,enginespeed,enginepower)
        {
            CargoWeight = cargoweight;
            CargoType = cargotype;
        }
    }

    class Tires : Cargo
    {
        public Tires() { }
        public double Tire1Pressure { get; set; }
        public int Tire1Age { get; set; }
        public double Tire2Pressure { get; set; }
        public int Tire2Age { get; set; }
        public double Tire3Pressure { get; set; }
        public int Tire3Age { get; set; }
        public double Tire4Pressure { get; set; }
        public int Tire4Age { get; set; }

        public Tires(string model, int enginespeed, int enginepower, int cargoweight,
            string cargotype,double tire1pressure,int tire1age, double tire2pressure,
            int tire2age, double tire3pressure, int tire3age, double tire4pressure, int tire4age)
            :base(model,enginespeed,enginepower,cargoweight,cargotype)
        {
            Tire1Pressure = tire1pressure;
            Tire1Age = tire1age;

            Tire2Pressure = tire2pressure;
            Tire2Age = tire2age;

            Tire3Pressure = tire3pressure;
            Tire3Age = tire3age;

            Tire3Pressure = tire3pressure;
            Tire3Age = tire3age;
        }

        public double findAllPressureValue()
        {
            double pressureValue = (Tire1Pressure + Tire2Pressure +Tire3Pressure + Tire4Pressure) / 4;
            return pressureValue;
        }
    }
}
