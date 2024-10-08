using System;

namespace OX_game
{
    public class Game
    {
        public void ReDraw(string[,]tab)
        {
            for (int x = 0; x < tab.GetLength(0); x++)
            {
                for (int y = 0; y < tab.GetLength(1); y++)
                {
                    
                    Console.Write(tab[x, y]);
                    if (y == tab.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }

            }
        }
        public string[,] CreateTab()
        {
            string[,] tab = new String[10, 50];

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = "_";
                }
               
            }
            

            

            return tab;
        }
    }
}