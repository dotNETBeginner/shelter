using System;

namespace Задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, k=0;
            Console.WriteLine("Input a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Input b");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Input c");
            c = float.Parse(Console.ReadLine());
            if (a < 0)
                k++;
            if (b < 0)
                k++;
            if (c < 0)
                k++;
            if(k%2==0)
                Console.Write($"Произведение чисел {a} {b} {c} - Позитивное");
            else
                Console.Write($"Произведение чисел  {a}  {b}  {c}  - Негативное");
        }
    }
}
