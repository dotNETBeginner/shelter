using System;
using System.Text.RegularExpressions;

namespace задание_4_лаба_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            Regex someReg = new Regex(@"<a href=[\w-\W]*>\w*<\/a>");


            while (s != "END")
            {
                s = Console.ReadLine();

                if (s != "END")
                {
                    foreach (var item in someReg.Matches(s))
                    {
                        string sb = item.ToString();

                        sb = sb.Replace("<a", "[URL");
                        sb = sb.Replace("</a>", "[/URL]");

                        Console.WriteLine(sb);
                    }

                }
            }
        }
    }
}
