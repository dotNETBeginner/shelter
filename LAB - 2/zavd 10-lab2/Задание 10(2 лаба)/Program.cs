using System;

namespace Задание_10_2_лаба_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, dif;
            Console.WriteLine("Введите размерность массива.");

            n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            Console.WriteLine("Введите данные в массив.");
            for (int i=0;i<n;i++) {num[i]=int.Parse(Console.ReadLine()); }

            Console.WriteLine("Введите разницу.");
            dif = int.Parse(Console.ReadLine());

            int[] DIFF = new int[20];
            int p = 0,counter=0;
            for(int j=0;j<n;j++)
            {
                for(int i=0;i<n;i++)
                {
                    if(num[i]-num[j]==dif)
                    {
                        DIFF[p] = num[i];
                        DIFF[p + 1] = num[j];
                        p+=2;
                        counter++;
                    }
                }
            }
            Array.Resize(ref DIFF,p);

            if (p > 0)
            {
                Console.WriteLine($"Пар, разница которых равна {dif} - {counter}");
                for (int i = 0; i < DIFF.Length; i++) { if (i != 0) { if (i % 2 == 0) { Console.Write("  "); } } Console.Write($"{DIFF[i]}  "); }
            }
            if (p == 0) { Console.WriteLine($"Нету таких пар, разница которых бы давала {dif}"); }
                
        }
    }
}
