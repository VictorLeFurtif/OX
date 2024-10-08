using System.Xml;

namespace OX_game
{
    public class Monster
    {
        public string monster = "o";
        
        public void MonsterBasePosition(string [,] tab)
        {
            for (int i = 7; i < tab.GetLength(0); i++)
            {
                for (int j = 8; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = monster;
                }
            }
        }
        
        public void MonsterMovement()
        {
           
        }
    }
}