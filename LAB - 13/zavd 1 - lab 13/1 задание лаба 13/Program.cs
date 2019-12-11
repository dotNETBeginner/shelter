using System;
using System.Text.RegularExpressions;

namespace _1_задание_лаба_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            Regex someReg = new Regex(@"\b[A-Z]{1}[a-z]*\s[A-Z]{1}[a-z]*\b");

            while (s != "END")
            {
                s = Console.ReadLine();

                if(s != "END")
                {

                    MatchCollection someMatches = someReg.Matches(s);

                    if (someMatches.Count > 0)
                    {
                        foreach (Match match in someMatches)
                        { Console.WriteLine(match.Value); }
                    }
                    else
                    { Console.WriteLine("No mathces!"); }

                }
            }
        }
    }
}
