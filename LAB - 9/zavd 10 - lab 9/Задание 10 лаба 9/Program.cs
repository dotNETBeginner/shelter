using System;

namespace Задание_10_лаба_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ");
            string s = "";

            Tuple<string, string> A = new Tuple<string, string>();
            Tuple<string, int> B = new Tuple<string, int>();
            Tuple<int, double> C=new Tuple<int, double>();
            for (int i=0; i<3;i++)
            {
                if (command.Length == 3)
                {
                    s += command[0];
                    s += " " + command[1];

                    A.Add(s,command[2]);
                }

                else
                {
                    bool IsDigit1 = Int32.TryParse(command[1],out int n);
                    bool IsDigit2 = Double.TryParse(command[1], out double t);
                    bool IsDigit3 = Int32.TryParse(command[0], out int t1);

                    if (IsDigit1) {  B.Add(command[0],int.Parse(command[1])); }

                     if(IsDigit3 && IsDigit2) { C.Add(int.Parse(command[0]),double.Parse(command[1])); }
                }

                command = Console.ReadLine().Split(" ");
            }

            A.Display();
            B.Display();
            C.Display();
        }
    }
}
