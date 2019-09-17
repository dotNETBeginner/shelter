using System;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double number,nDigit;
            int n;
            Console.WriteLine("Введите число");
            number=double.Parse(Console.ReadLine());
            Console.WriteLine("Введите порядковый номер цифры числа, который хотите увидеть на экране (Нумерация идёт справа на лево)");
            n = int.Parse(Console.ReadLine());
            //int n1 = n - 1;
            nDigit =((number / Math.Pow(10,n-1))%10.0d);
           
            Console.Write($"Результат - {Math.Truncate(nDigit)}");

        }
    }
}
