namespace OX_game
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game algo1 = new Game();
            string[,]tab = algo1.CreateTab();
            Hero algo2 = new Hero();
            algo2.HeroSpawn(tab);
            algo1.CreateTab();
            Monster algo = new Monster();
            algo.MonsterBasePosition(tab);
        }
    }
}