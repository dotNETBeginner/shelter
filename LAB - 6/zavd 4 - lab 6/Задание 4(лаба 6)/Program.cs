using System;

namespace Задание_4_лаба_6_
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Input number of songs");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Input artist name, song name, and song lenght");

                RadioDataBase someData = new RadioDataBase();
            
                for (int i = 0; i < n; i++)
                {
                    string[] s = Console.ReadLine().Split(';', ':');
                try
                {
                    someData.addSongInDataBase(n, s[0], s[1], int.Parse(s[2]), int.Parse(s[3]));
                }
                catch (InvalidSongException ise)
                { Console.WriteLine(ise.Message); }

                catch (InvalidArtistNameException iane)
                { Console.WriteLine(iane.Message); }

                catch (InvalidSongNameException isne)
                { Console.WriteLine(isne.Message); }

                catch (InvalidSongLenghtException isle)
                { Console.WriteLine(isle.Message); }

                catch (InvalidSongMinutesException isme)
                { Console.WriteLine(isme.Message); }

                catch (InvalidSongSecondsException isse)
                { Console.WriteLine(isse.Message); }
            }
                someData.Display();
                someData.DisplayStatus();

        }
    }
}
