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
        public void HeroSpawn(string[,]tab,int x1, int y1)
        {
            tab[x1, y1] = hero; 
            game.ReDraw(tab);
        }

        public void ControlHero(string[,] tab, int x1,int y1)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Z)
                    {
                        tab[x1+1,y1] = hero;
                        Console.Clear();
                        game.ReDraw(tab);
                    }
                }
            }
        }
    }
    
    
}