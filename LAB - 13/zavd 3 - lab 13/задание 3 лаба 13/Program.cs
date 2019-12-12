using System;
using System.Text.RegularExpressions;
namespace задание_3_лаба_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            while (s != "END")
            {
                s = Console.ReadLine();

                if (s != "END")
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        Regex someReg = new Regex($@"{s[i]}+");
                        s = someReg.Replace(s, $"{s[i]}");
                    }

                    Console.WriteLine(s);
                }
            }
        }
    }
}
