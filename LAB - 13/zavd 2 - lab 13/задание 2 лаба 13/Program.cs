using System;
using System.Text.RegularExpressions;

namespace задание_2_лаба_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            Regex someReg = new Regex(@"\+359(?<grp1>[- ])[0-9]\k<grp1>[0-9]{3}\k<grp1>[0-9]{4}\b");

            while(s != "END")
            {
                s = Console.ReadLine();

                if (s != "END")
                {
                    MatchCollection someMatches = someReg.Matches(s);

                    if (someMatches.Count > 0)
                    {
                        foreach (Match match in someMatches)
                        { Console.WriteLine(match.Value); }
                    }
                    else
                    { Console.WriteLine("No matches!"); }
                }
            }
        }
    }
}
