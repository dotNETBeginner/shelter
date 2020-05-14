using System;
using System.Collections.Generic;

namespace ХрестикиНолики
{

    class Player
    {
        public string Curs { get; set; }
        public bool isPlayerOnFigure { get; set; }
        public bool IsPlayerCreate { get; set; }
        public bool isSteped { get; set; }

        public Player(string curs)
        {
            Curs = curs;
            isPlayerOnFigure = false;
            isSteped = false;
            IsPlayerCreate = false;
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

        static string spike = "X";

        static string circle = "O";

        static void Main(string[] args)
        {

            Player pl1 = new Player("x");
            Player pl2 = new Player("o");

            frame.Add(new string[] { "-", "-", "-" });
            frame.Add(new string[] { " ", " ", " " });
            frame.Add(new string[] { "-", "-", "-" });
            frame.Add(new string[] { " ", " ", " " });
            frame.Add(new string[] { "-", "-", "-" });
            frame.Add(new string[] { "x", " ", " " });
            frame.Add(new string[] { "-", "-", "-" });
            Render(pl1);

            Player AllPlayers = pl1;

            while (gameStatus)
            {
                if(AllPlayers.isSteped)
                { Switch(pl1, pl2, ref AllPlayers); }

                var keyInfo = Console.ReadKey();
                MovePlayer(keyInfo, AllPlayers);

                Render(AllPlayers);

                WhoWin(AllPlayers.Figure(), ref gameStatus);
            }
        }

        static void Switch(Player player1, Player player2, ref Player aP)
        {
            if (player1.isSteped == true)
            { player1.isSteped = false; aP = player2; }
            else if (player2.isSteped == true)
            { player2.isSteped = false; aP = player1; } 


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

            string curs = sP.Curs;


            for (int x = frame.Count - 2; x >= 0; x -= 2)
            {
                    for (int y = 0; y < frame[x].Length; y++)
                    {
                        if (frame[x][y] == curs) //Находит указатель игрока
                        {

                        if(kI.Key == ConsoleKey.UpArrow) //Управление прямо
                            {
                                if ((x - 2) >= 0 && frame[x - 2][y] == EmptyCell)
                                {
                                if (sP.isPlayerOnFigure == true)//Проверка, находиться ли игрок на фигуре 
                                { frame[x][y] = temp; sP.isPlayerOnFigure = false; }//Если да, то место откуда курсор игрока ушёл, появиться знак фигуры,
                                if (sP.IsPlayerCreate == true)
                                { frame[x][y] = temp; sP.IsPlayerCreate = false; sP.isSteped = true; }
                                else
                                    frame[x][y] = EmptyCell; //Если нет, то место просто станет опять пустым 
                                
                                    frame[x - 2][y] = curs;
                                    return;
                                }
                                if((x - 2) >= 0 && ((frame[x - 2][y] == spike) || (frame[x - 2][y] == circle))) //Если впереди есть фигура
                                { 

                                    if (sP.isPlayerOnFigure == true)
                                    { frame[x][y] = temp; sP.isPlayerOnFigure = false; }
                                    if (sP.IsPlayerCreate == true)
                                    { frame[x][y] = temp; sP.IsPlayerCreate = false; sP.isSteped = true; }
                                    else
                                    frame[x][y] = EmptyCell;

                                    sP.isPlayerOnFigure = true; //То статус того что игрок находиться на фигуре активируеться

                                    temp = frame[x - 2][y]; //Знак фигуры сохраняется в переменной temp
                                    frame[x - 2][y] = curs;
                                return;

                                }
                            }

                        if(kI.Key == ConsoleKey.DownArrow) //Управление назад
                        {
                            if((x + 2) <= (frame.Count - 1) && frame[x+2][y] == EmptyCell)
                            {
                                if (sP.isPlayerOnFigure == true)
                               { frame[x][y] = temp; sP.isPlayerOnFigure = false; }
                                if (sP.IsPlayerCreate == true)
                                { frame[x][y] = temp; sP.IsPlayerCreate = false; sP.isSteped = true; }
                                else
                                    frame[x][y] = EmptyCell;
                                frame[x + 2][y] = curs;
                                return;
                            }
                            if((x + 2) <= (frame.Count - 1) && ((frame[x + 2][y] == spike) || (frame[x + 2][y] == circle)))
                                {
                                    if (sP.isPlayerOnFigure == true)
                                    { frame[x][y] = temp; sP.isPlayerOnFigure = false; }
                                    if (sP.IsPlayerCreate == true)
                                    { frame[x][y] = temp; sP.IsPlayerCreate = false; sP.isSteped = true; }
                                    else
                                    frame[x][y] = EmptyCell;

                                    sP.isPlayerOnFigure = true;

                                    temp = frame[x + 2][y];
                                    frame[x + 2][y] = curs;
                                return;
                                }
                        }

                        if(kI.Key == ConsoleKey.RightArrow) //Управление вправо
                        {
                            if((y + 1) <= (frame[x].Length - 1) && frame[x][y + 1] == EmptyCell)
                            {
                                if (sP.isPlayerOnFigure == true)
                                { frame[x][y] = temp; sP.isPlayerOnFigure = false; }
                                if (sP.IsPlayerCreate == true)
                                { frame[x][y] = temp; sP.IsPlayerCreate = false; sP.isSteped = true; }
                                else
                                    frame[x][y] = EmptyCell;
                                frame[x][y + 1] = curs;
                                return;
                            }
                            if((y + 1) <= (frame[x].Length - 1) && ((frame[x][y + 1] == spike) || (frame[x][y + 1] == circle)))
                            {
                                if (sP.isPlayerOnFigure == true)
                                { frame[x][y] = temp; sP.isPlayerOnFigure = false; }
                                if (sP.IsPlayerCreate == true)
                                { frame[x][y] = temp; sP.IsPlayerCreate = false; sP.isSteped = true; }
                                else
                                    frame[x][y] = EmptyCell;

                                sP.isPlayerOnFigure = true;
                                temp = frame[x][y + 1];
                                frame[x][y + 1] = curs;

                                return;
                            }
                        }

                        if(kI.Key == ConsoleKey.LeftArrow) //Управление влево
                        {
                            if((y - 1) >= 0 && frame[x][y - 1] == EmptyCell)
                            {
                                if (sP.isPlayerOnFigure == true)
                                { frame[x][y] = temp; sP.isPlayerOnFigure = false; }
                                if (sP.IsPlayerCreate == true)
                                { frame[x][y] = temp; sP.IsPlayerCreate = false; sP.isSteped = true; }
                                else
                                    frame[x][y] = EmptyCell;
                                frame[x][y - 1] = curs;
                                return;
                            }
                            if ((y - 1) >= 0 && ((frame[x][y - 1] == spike) || (frame[x][y - 1] == spike)))
                            {
                                if (sP.isPlayerOnFigure == true)
                                { frame[x][y] = temp; sP.isPlayerOnFigure = false; }
                                if (sP.IsPlayerCreate == true)
                                { frame[x][y] = temp; sP.IsPlayerCreate = false; sP.isSteped = true; }
                                else
                                    frame[x][y] = EmptyCell;

                                sP.isPlayerOnFigure = true;
                                temp = frame[x][y - 1];
                                frame[x][y - 1] = curs;

                                return;
                            }
                        }

                        if(kI.Key == ConsoleKey.Spacebar) //Оставление хрестика.
                        {
                            if(frame[x][y] != spike || frame[x][y] != circle)
                            {
                                sP.IsPlayerCreate = true;
                                temp = sP.Figure();
                                sP.isPlayerOnFigure = true;
                            }

                        }

                        }
                        
                    }
            }

        }

        static void MoveEnemy() //Псевдо ИИ Противника
        {
            for(int x = frame.Count - 2; x >= 0; x+=2)
            {
                for(int y = 0; y < frame[x].Length; y++)
                {
                  
                }
            }
        }

        static void Render(Player sP)
        {
            if (sP.isSteped)
            {
                for (int x = frame.Count - 2; x >= 0; x -= 2)
                {
                    for (int y = 0; y < frame[x].Length; y++)
                    {
                        if (frame[x][y] == sP.Curs)
                        { frame[x][y] = sP.opposite(); }
                    }
                }
            }
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Управлять стрелками\n ставить хрестик на space\n игра уже не такая сырая (- _ -)\n");
            Console.ResetColor();

            Console.WriteLine($"IsPlayerOnFigure : {sP.isPlayerOnFigure}\n {sP.Curs}\n IsSteped : {sP.isSteped}\n isPlayerCreate : {sP.IsPlayerCreate}\n temp : {temp}");

            for (int x = 0; x < frame.Count; x++)
            {
                Console.WriteLine(string.Join("  ", frame[x]));
            }

            Console.WriteLine("\nXrestikiNoliki 0.0.3");
        }
    }
}
