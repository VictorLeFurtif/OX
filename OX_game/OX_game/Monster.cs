using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace OX_game
{
    public class Monster
    {
        public Game game;
        public int x2 = 5;
        public int y2 = 5;
        public string monster = "o";

        public void MonsterSpawn(string[,] tab)
        {
            tab[x2, y2] = monster;
            game.ReDraw(tab);
        }

        public void ControlMonster(string[,] tab)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.UpArrow)
                    {
                        if (x2 == 0)
                        {
                            return;
                        }

                        tab[x2, y2] = "_";
                        x2++;
                        tab[x2, y2] = monster;
                    }
                    if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                    {
                        if (x2 == -1)
                        {
                            return;
                        }

                        tab[x2, y2] = "_";
                        x2++;
                        tab[x2, y2] = monster;
                    }
                    if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
                    {
                        if (y2 == 0)
                        {
                            return;
                        }

                        tab[x2, y2] = "_";
                        x2++;
                        tab[x2, y2] = monster;
                    }
                    if (Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
                    {
                        if (y2 == -1)
                        {
                            return;
                        }

                        tab[x2, y2] = "_";
                        x2++;
                        tab[x2, y2] = monster;
                    }
                }
            }
        }
        
    }
}