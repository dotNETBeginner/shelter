using System;
using System.Collections.Generic;
using System.Text;

namespace _2_задание_8_лаба
{
    class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public virtual void ExplainSelf() => Console.WriteLine($"I am {Name} and my favourite food is {FavouriteFood}");
    }
}
