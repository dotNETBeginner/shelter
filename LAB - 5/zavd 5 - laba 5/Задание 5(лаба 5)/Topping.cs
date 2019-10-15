using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5_лаба_5_
{
    class Topping
    {
        private string typeOfTopping;
        private int toppingWeight;
        
        public string TypeOfTopping
        {
            get { return typeOfTopping; }
            set
            {
                if (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce")
                { Console.WriteLine($"Cannot place {value} on top of your pizza.\n"); }
                else { typeOfTopping = value; }

                if (value == "Meat") { ToppingModifier = 1.2f; }
                if (value == "Veggies") { ToppingModifier = 0.8f; }
                if (value == "Cheese") { ToppingModifier = 1.1f; }
                if (value == "Sauce") { ToppingModifier = 0.9f; }
            }
        }
        public float ToppingModifier { get; set; }
        public int ToppingWeight
        {
            get { return toppingWeight; }
            set
            {
                if (value <= 0 || value > 50)
                { if (typeOfTopping != null) { Console.WriteLine($"{TypeOfTopping} weight should be in the range [1..50]\n"); } }
                else { toppingWeight = value; }
            }
        }

        public Topping(string[] s)
        {
            TypeOfTopping = s[1];
            ToppingWeight = int.Parse(s[2]);
        }
    }
}
