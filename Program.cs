using System;

namespace NavalBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.SetPlayerNameNumber(player1);
            player1.CreateMap();
            player1.ShowMap();
            player1
            
            Player player2 = new Player();
            player2.SetPlayerNameNumber(player2);
            player2.CreateMap();
            player2.ShowMap();
            

        }
    }
}
