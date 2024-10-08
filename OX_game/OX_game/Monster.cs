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
            tab[9, 47] = monster; 
            game.ReDraw(tab);

        }
        
        public void MonsterMovement(string[,]tab)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Z)
                    { 
                        tab[9, 48] = monster;
                        Console.Clear();
                        game.ReDraw(tab);
                    }
                }
            }
        }
    }
}