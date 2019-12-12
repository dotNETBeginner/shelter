using System;

namespace задание_1_лаба_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int n = s.Length/2;

            char[] cs = new char[s.Length];

            for(int i = 0; i < s.Length; i++)
            { cs[i] = s[i]; }

                int j = s.Length-1;

                for(int i = 0; i < n; i++)
                {
                    char t = cs[j];
                    cs[j] = cs[i];
                    cs[i] = t;
                    j--;
                }


            for(int i = 0; i < s.Length; i++)
            { Console.Write(cs[i]); }
        }
    }
}
