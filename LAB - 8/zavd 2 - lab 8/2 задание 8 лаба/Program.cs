using System;

namespace _2_задание_8_лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя и любомое блюдо кошки");
            string[] s = Console.ReadLine().Split(" ");

            Cat someCat = new Cat(s[0], s[1]);

            Console.WriteLine("Введите имя и любомое блюдо собаки");
            s = Console.ReadLine().Split(" ");

            Dog someDog = new Dog(s[0], s[1]);

            someCat.ExplainSelf();
            someDog.ExplainSelf();
        }
    }
}
