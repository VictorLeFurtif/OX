﻿namespace OX_game
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game algo1 = new Game();
            string[,]tab = algo1.CreateTab();
            Hero algo2 = new Hero();
            Monster algo = new Monster();
            algo.MonsterBasePosition(tab);
            algo2.game = algo1;
            algo2.HeroSpawn(tab);
            algo1.CreateTab();
        }
    }
}