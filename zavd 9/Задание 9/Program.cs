using System;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float number, min;
            Console.WriteLine("Введите число");
            number = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальное число для прохода");
            min = float.Parse(Console.ReadLine());
            if (number % 2 != 0 && number > min)
                   {
                Console.Write($"Заданое вами число является не парным, и оно больше {min}");
                }
            if (number % 2 != 0 && number < min)
            {
                Console.Write($"Заданое вами число является не парным, но оно меньше {min}");
            }
            if (number % 2 == 0 && number > min)
            {
                Console.Write($"Заданое вами число является парным, но оно хотя бы больше {min}");
            }
            if (number % 2 == 0 && number < min)
            {
                Console.Write($"Заданое вами число является парным, и оно меньше {min}");
            }
        }
    }
}
