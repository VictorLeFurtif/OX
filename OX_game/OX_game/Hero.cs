using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace OX_game
{
    public class Hero
    {
        public string hero = "x";
        public Game game;
        public int x1 = 9;
        public int y1 = 47;

        public void HeroSpawn(string[,] tab)
        {
            tab[x1, y1] = hero;
            game.ReDraw(tab);
        }

        public void DirectionalTop(string[,] tab)
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Z)
                {
                    if (x1 == 0)
                    {
                        return;
                    }

                    tab[x1, y1] = "_";
                    x1--;
                    tab[x1, y1] = hero;
                    game.ReDraw(tab);
                        
                }
                    
            }
        }
        public void DirectionalBot(string[,] tab)
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    if (x1 == tab.GetLength(0)-1)
                    {
                        
                        return;
                    }

                    tab[x1, y1] = "_";
                    x1++;
                    tab[x1, y1] = hero;
                    game.ReDraw(tab);
                        
                }
                    
            }
        }
        public void DirectionalLeft(string[,] tab)
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    if (y1 == 0)
                    {
                        
                        return;
                    }

                    tab[x1, y1] = "_";
                    y1--;
                    tab[x1, y1] = hero;
                    game.ReDraw(tab);
                        
                }
                    
            }
        }
        public void DirectionalRight(string[,] tab)
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.D)
                {
                    if (y1 == tab.GetLength(1)-1)
                    {
                        
                        return;
                    }

                    tab[x1, y1] = "_";
                    y1++;
                    tab[x1, y1] = hero;
                    game.ReDraw(tab);
                        
                }
                    
            }
        }
        public void ControlHero(string[,] tab)
        {
            while (true)
            {
               DirectionalTop(tab); 
               DirectionalBot(tab);
               DirectionalLeft(tab);
               DirectionalRight(tab);
            }
        }
    }
        
}
