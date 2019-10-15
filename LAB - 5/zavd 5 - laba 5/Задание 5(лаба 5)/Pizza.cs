using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5_лаба_5_
{
    class Pizza
    {
        public string Name { get; set; }

        Dough dough;
        List<Topping> topping = new List<Topping>();

        public Pizza() { }
        public Pizza(string[] s) { Name = s[1]; }

        public void addDoughInPizza(string[] s) { dough = new Dough(s); }
        
        public void addToppingInPizza(string[] s)
        {
            Topping t = new Topping(s);
            topping.Add(t);
        }

        public void displayCaloryOfPizza()
        {
            float caloryOfDough=0;
            float[] caloryOfTopping = new float[topping.Count];
            float caloryOfToppingSum = 0;
            float result=0;

                caloryOfDough = (2 * dough.DoughWeight) * dough.DoughModifier * dough.BakingTechniqueModifier;
            for (int i = 0; i < topping.Count; i++)
            { caloryOfTopping[i] = (2 * topping[i].ToppingWeight) * topping[i].ToppingModifier; caloryOfToppingSum += caloryOfTopping[i]; }

            if (topping.Count > 10) { Console.WriteLine($"Number of toppings should be in range [0..10]"); }
            else
            {
                result = caloryOfDough + caloryOfToppingSum;
                Console.WriteLine($"{Name} - {result.ToString("0.00")}");

            }
            
        }
        }
    }
