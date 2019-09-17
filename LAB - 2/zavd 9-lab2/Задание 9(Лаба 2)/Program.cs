using System;

namespace Задание_9_Лаба_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alpha = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };

            string wordZ;

            Console.WriteLine("Введите слово.");
            wordZ = Console.ReadLine();

            char[] word = new char[wordZ.Length];
            for (int i=0;i<wordZ.Length;i++) {word[i]=wordZ[i]; }

            for (int j = 0; j < word.Length; j++)
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                    if (word[j] == alpha[i]) { Console.WriteLine($"{word[j]} -> {i}"); }
                        
                }
            }
        }
    }
}
