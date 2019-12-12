using System;
using System.Text.RegularExpressions;
namespace _5_задание_13_лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            Regex someReg = new Regex(@"\b\w{1}[a-zA-Z0-9\._-]*@[a-zA-Z0-9-_\.]*\.[a-z]*\b");

            while(s != "END")
            {
                s = Console.ReadLine();

                if(s != "END")
                {
                    MatchCollection someMatches = someReg.Matches(s);

                    if (someMatches.Count > 0)
                    {
                        foreach (Match match in someMatches)
                        { Console.WriteLine(match); }
                    }
                    else
                    { Console.WriteLine("No matches!"); }
                }
            }

        }
    }
}
