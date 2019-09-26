using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_7_лаба_3_
{
    class Car
    {
        public string Model { get; set; }
        public float FuelAmount { get; set; }

        public float FuelConsumptionFor1km { get; set; }

        private int distanceTreveled = 0;

        public int DistanceTreveled
        {
            get {return distanceTreveled; }
            set { distanceTreveled = value; }
        }


        public Car() { }

        public Car(string Model,float FuelAmount,float FuelConsumptionFor1km)
        {
            this.Model = Model;
            this.FuelAmount = FuelAmount;
            this.FuelConsumptionFor1km = FuelConsumptionFor1km;
        }

        public void Display()
        {
            Console.WriteLine($"{Model} {FuelAmount.ToString("0.00")} { DistanceTreveled}km {FuelConsumptionFor1km}");
        }

        public void DisplayForCheckFuel()
        {
            Console.WriteLine($"{Model} {FuelAmount.ToString("0.00")} { DistanceTreveled}km");
        }

        public void CheckFuel(int Distance)
        {
            float expenses = Distance*FuelConsumptionFor1km;
            FuelAmount -= expenses;

            if (FuelAmount >= 0) { DistanceTreveled+=Distance; DisplayForCheckFuel(); }
            else
            {
                Console.WriteLine("Недостаточно топлива для преодоления такой дистанции!");
                FuelAmount += expenses;
            }
        }

    }
}
