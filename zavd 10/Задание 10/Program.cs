using System;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введите число");
            number = int.Parse(Console.ReadLine());
            if(number%9==0|| number % 11 == 0|| number % 13 == 0)
            {
                Console.Write("Ваше число делится либо на 11, либо на 13, либо на 9");
            }
            else
            {
                Console.Write("Ваше число не делится  на 11, на 13, и на 9");
            }
        }
    }
}
