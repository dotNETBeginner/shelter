using System;

namespace задание_2_лаба_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int n = 20; 

            for(int i = 0; i < n; i++)
            {
                if (i < s.Length)
                {
                    if (s[i] == '"')
                    {
                        i++;
                        n++;
                    }
                     Console.Write(s[i]);  
                }

                else if(i >= s.Length)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
