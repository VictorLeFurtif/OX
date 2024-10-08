using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace OX_game
{
    public class Monster
    {
        public Game game;
        public int x2 = 0;
        public int y2 = 2;
        public string monster = "o";

        public void MonsterSpawn(string[,] tab)
        {
            tab[x2, y2] = monster;
            game.ReDraw(tab);
        }

        public void DirectionalTop(string[,] tab)
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
                    x2--;
                    tab[x2, y2] = monster;
                    game.ReDraw(tab);
                        
                }
                    
            }
        }
        public void DirectionalBot(string[,] tab)
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                {
                    if (x2 == tab.GetLength(0)-1)
                    {
                        
                        return;
                    }

                    tab[x2, y2] = "_";
                    x2++;
                    tab[x2, y2] = monster;
                    game.ReDraw(tab);
                        
                }
                    
            }
        }
        public void DirectionalLeft(string[,] tab)
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
                {
                    if (y2 == 0)
                    {
                        
                        return;
                    }

                    tab[x2, y2] = "_";
                    y2--;
                    tab[x2, y2] = monster;
                    game.ReDraw(tab);
                        
                }
                    
            }
        }
        public void DirectionalRight(string[,] tab)
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
                {
                    if (y2 == tab.GetLength(1)-1)
                    {
                        
                        return;
                    }

                    tab[x2, y2] = "_";
                    y2++;
                    tab[x2, y2] = monster;
                    game.ReDraw(tab);
                        
                }
                    
            }
        }
        
    }
        
}
