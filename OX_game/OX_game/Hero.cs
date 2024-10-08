using System;
using System.Net.Sockets;

namespace OX_game
{
    public class Hero
    {
        public string hero = "x";

        public void HeroSpawn(string[,]tab)
        {
            hero = tab[9, 47];
            
            
            
        }
        
        public void ControlHero()
        {
        
        }
    }
    
    
}