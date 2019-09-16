using System;

namespace Задание_8_2_лаба_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите размерность массива.");

            n = int.Parse(Console.ReadLine());

            n++;

            int[] a = new int[n];

            int n1 = n;
            int[] nb = new int[n1];
            int[] ind = new int[n1];

            a[n - 1] = -9500; //Костыли
            for (int i=0;i<n;i++) { if (i != n - 1) a[i] = int.Parse(Console.ReadLine());}

            int d, inx=0,p=0;
            for (int k = 0; k < n; k++)
            {
                d = a[0];
                for (int i = 0; i < n; i++)
                {
                    if (a[i] == d)
                    {
                        inx++;
                    }
                    if (a[i] == d)
                    {
                        nb[p] = a[i];
                        ind[p] = inx;
                    }
                    if (a[i] == d)
                    {
                        for (int j = i; j < n - 1; j++) { a[j] = a[j + 1]; }
                        n--;
                        Array.Resize(ref a,n);
                        i--;
                    }
                }
                inx = 0;
                p++;
            }
            Array.Resize(ref nb, p);
            Array.Resize(ref ind, p);

            Console.WriteLine();

            int max = ind[0];

            for(int i=0;i<p;i++)
            {
                if (max < ind[i]) {max=ind[i]; }
            }
            Console.WriteLine(max);

            for(int i=0;i<p;i++)
            {
                if (ind[i] == max) { Console.Write($"Число {nb[i]} повторяется {ind[i]} раз\n"); }
                
            }
            for (int i = 0; i < p; i++)
            {
                if (ind[i] == max) { Console.WriteLine($"Самое левое число - {nb[i]}"); break; }
                
                }
        }
    }
}
