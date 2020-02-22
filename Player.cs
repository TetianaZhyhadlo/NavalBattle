using System;
using System.Collections.Generic;
using System.Text;

namespace NavalBattle
{
    public class Player:Map
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public void SetPlayerNameNumber(Player player1)
        {
            Console.WriteLine("Enter player name:");
            player1.Name = Console.ReadLine();
            Console.WriteLine("Enter player number:");
            player1.Number = Convert.ToInt32(Console.ReadLine());
        }

    }
}
