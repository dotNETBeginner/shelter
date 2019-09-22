using System;

namespace Задание_5_лаба_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слово");
            string w1 = Console.ReadLine();
            Console.WriteLine("Введите второе слово");
            string w2 = Console.ReadLine();

            char[] word1=new char[w1.Length];
            char[] word2=new char[w2.Length];

            for(int i = 0; i < w1.Length; i++) { word1[i] = w1[i]; }
            for (int i = 0; i < w2.Length; i++) { word2[i] = w2[i]; }


            int m;

            if (word1.Length < word2.Length) { m = word1.Length; } else { m = word2.Length; }

            int c1=0, c2=0;

            for(int i=0;i<m;i++)
            {
                if (word1[i] > word2[i])
                {
                    for (int j = 0; j < word2.Length; j++) { if(word2[j]!=' ')Console.Write(word2[j]);c1++; }
                    Console.WriteLine();
                    for (int q = 0; q < word1.Length; q++) { if (word1[q] != ' ') Console.Write(word1[q]); c2++; }
                    break;
                }
                else if(word1[i] < word2[i])
                {
                    for (int j = 0; j < word1.Length; j++) { if (word1[j] != ' ') Console.Write(word1[j]); }
                    Console.WriteLine();
                    for (int q = 0; q < word2.Length; q++) { if (word2[q] != ' ') Console.Write(word2[q]); }
                    break;
                }
                else if(word1[i] == word2[i]) {continue; }
            }
            if(c1==0&&c2==0)
            {
                for (int j = 0; j < word1.Length; j++) { if (word2[j] != ' ') Console.Write(word1[j]); }
                Console.WriteLine();
                for (int q = 0; q < word2.Length; q++) { if (word2[q] != ' ') Console.Write(word2[q]); }
            }
         
        }
    }
}
