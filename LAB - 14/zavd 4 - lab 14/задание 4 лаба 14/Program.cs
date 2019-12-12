using System;
using System.Collections.Generic;
namespace задание_4_лаба_14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> someS = new List<string[]>();

            string p = Console.ReadLine();

            string[] s = Console.ReadLine().Split('?','.','!');

            for (int i = 0; i < s.Length; i++)
            {
                string[] m = s[i].Split(" ");
                someS.Add(m);
            }

            for (int q = 0; q < s.Length; q++)
            {
                for (int i = 0; i < someS.Count; i++)
                {
                    if (i == q)
                    {
                        for (int j = 0; j < someS[i].Length; j++)
                        {
                            if(someS[i][j] == p)
                            Console.WriteLine(s[i]);
                        }
                        break;
                    }
                }
            }


        }
    }
}
