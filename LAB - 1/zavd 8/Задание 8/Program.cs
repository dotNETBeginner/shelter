using System;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double number, n, nDigit;
            Console.WriteLine("Введите число");
            number=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите порядковый номер цифры числа, который хотите увидеть на экране (Нумерация идёт справа на лево)");
            n = int.Parse(Console.ReadLine());
            nDigit =Convert.ToInt32((number/Math.Pow(10,n-1))%10);
            Console.Write($"Результат - {nDigit}");

        }
    }
}
