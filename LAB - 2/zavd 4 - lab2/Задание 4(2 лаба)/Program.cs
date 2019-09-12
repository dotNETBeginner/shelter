using System;

namespace Задание_4_2_лаба_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Введите конец диапазона, для поиска простых чисел.");

            n = int.Parse(Console.ReadLine());

            int[] prime = new int[n - 1];

            int j = 2;
            for (int i = 0; i < n - 1; i++)
            {
                prime[i] = j;
                j++;
            }

            int k=prime[0],p=0,s=prime.Length;

            for (int q=0;q<s;q++)
            {
                for (int i = p; i < s; i++)
                {
                    if (prime[i] != 0)
                    {
                        k = prime[i];
                        break;
                    }
                }

                for (int i = p; i < s; i++)
                {
                    if (prime[i] > k)
                    {
                        if (prime[i] % k == 0) { prime[i] = 0;  }
                    }
                    if (prime[s - 1] == 0)
                    {
                        s--;
                        Array.Resize(ref prime, s);
                    }
                    //if (prime[s - 1] == k) { turn = false; }
                    if (i == s - 1) { p++; }
                }
            }
              
           

            for (int i = 0; i < s; i++) { if (prime[i] != 0) { Console.Write(prime[i]+" "); } }

        }
    }
}
