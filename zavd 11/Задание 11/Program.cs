using System;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max=0;
            Console.WriteLine("Введите a");
            a =int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = int.Parse(Console.ReadLine());
            for(int i=0;i<3;i++)
            {
                if (max < a)
                    max = a;
                if(i==1)
                {
                    if (max < b)
                        max = b; 
                }
                if(i==2)
                {
                    if (max < c)
                        max = c;
                }
            }
            Console.Write($"Максимальное значение среди введённых вами чисел - {max}");
        }
    }
}
