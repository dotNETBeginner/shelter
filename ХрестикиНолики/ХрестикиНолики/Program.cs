using System;
using System.Collections.Generic;

namespace ХрестикиНолики
{

    class Player
    {
        public string Curs { get; set; }

        public bool isSteped { get; set; }

        public int PlaceCount { get; set; }

        public Player(string curs)
        {
            Curs = curs;
            isSteped = false;
        }

        public string opposite()
        {
            if (Curs == "x")
                return "o";
            else
                return "x";
        }

        public string Figure()
        {
            if (Curs == "x")
                return "X";
            else
                return "O";
        }
    }

    class Program
    {
        static List<string[]> frame = new List<string[]>();

        static string EmptyCell = " ";

        static bool gameStatus = true;

        static string temp = "";

        static byte drawCount = 0;

        static string spike = "X";

        static string circle = "O";

        static bool isPlayerOnFigure = false;

        static bool IsPlayerCreate = false;

        static void Main(string[] args)
        {

            Player pl1 = new Player("x");
            Player pl2 = new Player("o");

            Player AllPlayers = pl1;

            frame.Add(new string[] { "-", "-", "-" });
            frame.Add(new string[] { " ", " ", " " });
            frame.Add(new string[] { "-", "-", "-" });
            frame.Add(new string[] { " ", " ", " " });
            frame.Add(new string[] { "-", "-", "-" });
            frame.Add(new string[] { "x", " ", " " });
            frame.Add(new string[] { "-", "-", "-" });
            Render(pl1, pl2, ref AllPlayers);

            while (gameStatus)
            {
                var keyInfo = Console.ReadKey();
                MovePlayer(keyInfo,AllPlayers);

                Render(pl1, pl2, ref AllPlayers);

                CheckDraw(AllPlayers);

                WhoWin(spike, ref gameStatus);
                WhoWin(circle, ref gameStatus);
            }
        }

        static void Switch(Player player1, Player player2, ref Player aP)
        {
            if (player1.isSteped == true)
            { player1.isSteped = false; ChangeFigure(player1); aP = player2; }

            else if (player2.isSteped == true)
            { player2.isSteped = false; ChangeFigure(player2); aP = player1; }
        }

        static void ChangeFigure(Player pl)
        {
            for (int x = frame.Count - 2; x >= 0; x -= 2)
            {
                for (int y = 0; y < frame[x].Length; y++)
                {
                    if (frame[x][y] == pl.Curs)
                    { frame[x][y] = pl.opposite(); }
                }
            }
        }

        static void CheckDraw(Player p)
        {
            if (p.PlaceCount == 4)
                drawCount++;
            if (drawCount == 2)
                gameStatus = false;
        }

        static void WhoWin(string f, ref bool gStatus)
        {
            int counterX = 0;
            int counterY = 0;
            int counterD = 0;
            int counterlD = 0;

                for (int x = frame.Count - 2; x >= 0; x-= 2) //для Горизонтали
                {
                    for(int y = 0; y < frame[x].Length; y++)
                    {
                        if(frame[x][y] == f )
                        counterX++;
                    }
                 if (counterX == 3)
                     gStatus = false;
                 else
                    counterX = 0;
                }

                for(int y = 0; y < frame[frame.Count - 2].Length; y++) //для Диагонали
                {
                    for(int x = frame.Count - 2; x >=0; x-=2)
                    {
                        if (frame[x][y] == f)
                        counterY++;
                    }
                if (counterY == 3)
                    gStatus = false;
                else
                    counterY = 0;
            }

            for(int x = 1; x <= frame.Count - 2; x += 2)
            {
                int n = frame[x].Length;
                for(int y = 0; y < n; y++)
                {
                    int y1 = y + 1;

                    if (x == (y + (y1)))
                        if(frame[x][y] == f)
                          counterD++;

                    if ((x/2)+y == n-1)
                        if (frame[x][y] == f)
                            counterlD++;
                }
            }
            if (counterD == 3)
                gStatus = false;
            if (counterlD == 3)
                gStatus = false;

        }

        static void MovePlayer(ConsoleKeyInfo kI, Player sP)
        {
            for (int x = frame.Count - 2; x >= 0; x -= 2)
            {
                    for (int y = 0; y < frame[x].Length; y++)
                    {
                        if (frame[x][y] == sP.Curs) //Находит указатель игрока
                        {

                        if(kI.Key == ConsoleKey.UpArrow) //Управление прямо
                            {
                                if ((x - 2) >= 0 && frame[x - 2][y] == EmptyCell)
                                {
                                if (!isPlayerOnFigure && !IsPlayerCreate)
                                    frame[x][y] = EmptyCell;

                                if (IsPlayerCreate == true)
                                { frame[x][y] = temp; IsPlayerCreate = false; sP.isSteped = true; }

                                if (isPlayerOnFigure == true)
                                { frame[x][y] = temp; isPlayerOnFigure = false; }
                                
                                    frame[x - 2][y] = sP.Curs;
                                    return;
                                }
                                if((x - 2) >= 0 && ((frame[x - 2][y] == spike) || (frame[x - 2][y] == circle))) //Если впереди есть фигура
                                {
                                    if (!isPlayerOnFigure && !IsPlayerCreate)
                                    frame[x][y] = EmptyCell;

                                    if (IsPlayerCreate == true)
                                    { frame[x][y] = temp; IsPlayerCreate = false; sP.isSteped = true; }

                                    if (isPlayerOnFigure == true)
                                    { frame[x][y] = temp; isPlayerOnFigure = false; }

                                    isPlayerOnFigure = true; 

                                    temp = frame[x - 2][y]; 
                                    frame[x - 2][y] = sP.Curs;

                                    return;

                                }
                            }

                        if(kI.Key == ConsoleKey.DownArrow) //Управление назад
                        {
                            if((x + 2) <= (frame.Count - 1) && frame[x+2][y] == EmptyCell)
                            {
                                if (!isPlayerOnFigure && !IsPlayerCreate)
                                 frame[x][y] = EmptyCell;

                                if (IsPlayerCreate == true)
                                { frame[x][y] = temp; IsPlayerCreate = false; sP.isSteped = true; }

                                if (isPlayerOnFigure == true)
                                { frame[x][y] = temp; isPlayerOnFigure = false; }

                                frame[x + 2][y] = sP.Curs;
                                return;
                            }
                            if((x + 2) <= (frame.Count - 1) && ((frame[x + 2][y] == spike) || (frame[x + 2][y] == circle)))
                                {
                                    if (!isPlayerOnFigure && !IsPlayerCreate)
                                    frame[x][y] = EmptyCell;

                                    if (IsPlayerCreate == true)
                                    { frame[x][y] = temp; IsPlayerCreate = false; sP.isSteped = true; }

                                    if (isPlayerOnFigure == true)
                                    { frame[x][y] = temp; isPlayerOnFigure = false; }

                                    isPlayerOnFigure = true;

                                    temp = frame[x + 2][y];
                                    frame[x + 2][y] = sP.Curs;

                                    return;
                                }
                        }

                        if(kI.Key == ConsoleKey.RightArrow) //Управление вправо
                        {
                            if((y + 1) <= (frame[x].Length - 1) && frame[x][y + 1] == EmptyCell)
                            {
                                if (!isPlayerOnFigure && !IsPlayerCreate)
                                    frame[x][y] = EmptyCell;

                                if (IsPlayerCreate == true)
                                { frame[x][y] = temp; IsPlayerCreate = false; sP.isSteped = true; }

                                if (isPlayerOnFigure == true)
                                { frame[x][y] = temp; isPlayerOnFigure = false; }

                                frame[x][y + 1] = sP.Curs;
                                return;
                            }
                            if((y + 1) <= (frame[x].Length - 1) && ((frame[x][y + 1] == spike) || (frame[x][y + 1] == circle)))
                            {
                                if (!isPlayerOnFigure && !IsPlayerCreate)
                                    frame[x][y] = EmptyCell;

                                if (IsPlayerCreate == true)
                                { frame[x][y] = temp; IsPlayerCreate = false; sP.isSteped = true; }

                                if (isPlayerOnFigure == true)
                                { frame[x][y] = temp; isPlayerOnFigure = false; }

                                isPlayerOnFigure = true;

                                temp = frame[x][y + 1];
                                frame[x][y + 1] = sP.Curs;

                                return;
                            }
                        }

                        if(kI.Key == ConsoleKey.LeftArrow) //Управление влево
                        {
                            if((y - 1) >= 0 && frame[x][y - 1] == EmptyCell)
                            {
                                if (!isPlayerOnFigure && !IsPlayerCreate)
                                    frame[x][y] = EmptyCell;

                                if (IsPlayerCreate == true)
                                { frame[x][y] = temp; IsPlayerCreate = false; sP.isSteped = true; }

                                if (isPlayerOnFigure == true)
                                { frame[x][y] = temp; isPlayerOnFigure = false; }

                                frame[x][y - 1] = sP.Curs;
                                return;
                            }
                            if ((y - 1) >= 0 && ((frame[x][y - 1] == spike) || (frame[x][y - 1] == circle)))
                            {
                                if (!isPlayerOnFigure && !IsPlayerCreate)
                                    frame[x][y] = EmptyCell;

                                if (IsPlayerCreate == true)
                                { frame[x][y] = temp; IsPlayerCreate = false; sP.isSteped = true; }

                                if (isPlayerOnFigure == true)
                                { frame[x][y] = temp; isPlayerOnFigure = false; }

                                isPlayerOnFigure = true;

                                temp = frame[x][y - 1];
                                frame[x][y - 1] = sP.Curs;

                                return;
                            }
                        }

                        if(kI.Key == ConsoleKey.Spacebar) //Оставление хрестика.
                        {
                            if(!isPlayerOnFigure)
                            {
                                IsPlayerCreate = true;
                                isPlayerOnFigure = true;

                                temp = sP.Figure();

                                sP.PlaceCount++;

                            }

                        }

                        }
                        
                    }
            }

        }

        static void Render(Player sP1, Player sP2, ref Player aP)
        {
            Switch(sP1, sP2, ref aP);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Управлять стрелками\n ставить хрестик на space\n Игра на финальной стадии разработки");
            Console.ResetColor();

            //Console.WriteLine($"IsPlayerOnFigure : {isPlayerOnFigure}\n {aP.Curs}\n IsSteped : {aP.isSteped}\n isPlayerCreate : {IsPlayerCreate}\n temp : {temp}\n PlaceCount: {aP.PlaceCount}");

            for (int x = 0; x < frame.Count; x++)
            {
                Console.WriteLine(string.Join("  ", frame[x]));
            }

            Console.WriteLine("\nXrestikiNoliki 0.0.5");
        }
    }
}
