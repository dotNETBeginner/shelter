using System;

namespace Задание_2_лаба_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Введите количество элементов массива.");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество вращений массива.");
            k = int.Parse(Console.ReadLine());

            int[] sumArray = new int[n];
            int[] array = new int[n];

            Console.WriteLine("Введите данные в массив");

            for (int i = 0; i < n; i++) { array[i] = int.Parse(Console.ReadLine()); }
             
            for(int j = 0;j<k;j++)
            {
                int t = array[n-1];
                for (int i = n - 1; i > 0; i--) { array[i] = array[i - 1]; } 
                    array[0] = t;
                    for(int p = 0; p < n; p++) { sumArray[p] += array[p]; }
                

            }
            Console.WriteLine("Результат");
            for (int i = 0; i < n; i++) { Console.Write(sumArray[i] + " "); }
        }
    }
}
