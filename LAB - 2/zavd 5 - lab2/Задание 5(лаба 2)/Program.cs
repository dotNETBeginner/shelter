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
                if (word1[i] < word2[i]) { c1++; }
                else if(word2[i] < word1[i]) { c2++; }
            }
            Console.WriteLine();
            if((c1>c2&&word1.Length==word2.Length)||(c1 == c2 && word1.Length == word2.Length)||((c1 == c2 && word1.Length < word2.Length)))
            {
                for(int i = 0; i < word1.Length; i++) { if(word1[i]!=' ')Console.Write(word1[i]); }
                Console.WriteLine();
                for (int i = 0; i < word2.Length; i++) { if (word2[i] != ' ') Console.Write(word2[i]); }
            }
            else if((c2>c1 && word1.Length == word2.Length)|| (c1 == c2 && word1.Length > word2.Length))
            {
                for (int i = 0; i < word2.Length; i++) { if (word2[i] != ' ') Console.Write(word2[i]); }
                Console.WriteLine();
                for (int i = 0; i < word1.Length; i++) { if (word1[i] != ' ') Console.Write(word1[i]); }
            }
        }
    }
}
