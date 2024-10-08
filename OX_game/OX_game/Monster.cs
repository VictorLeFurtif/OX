using System;
using System.Xml;

namespace OX_game
{
    public class Monster
    {
        public string monster = "o";
        public Game game;
        
        public void MonsterBasePosition(string [,] tab)
        {
            tab[2, 5] = monster; 
        }
        
        public void MonsterMovement(string[,]tab)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.UpArrow)
                    { 
                        tab[2, 6] = monster;
                        Console.Clear();
                    }
                }
            }
        }
    }
}