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

        public void HeroSpawn(string[,]tab)
        {
            tab[9, 47] = hero; 
            game.ReDraw(tab);



        }
        
        public void ControlHero(string[,]tab)
        {
            while (true)
                if (Console.KeyAvailable) 
                    if (Console.ReadKey(true).Key == ConsoleKey.Z)
                    { 
                        tab[9, 48] = hero;
                        Console.Clear();
                        game.ReDraw(tab);
                    }
        }
    }
    
    
}