using System;

namespace NavalBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name for player1");
            Player player1 = new Player();
            player1.Name = Console.ReadLine();
            player1.Number = 1;
            player1.CreateMap();
            player1.ShowMap();

            
            Console.WriteLine("Enter name for player2");
            Player player2 = new Player();
            player2.Name = Console.ReadLine();
            player2.Number = 2;
            player2.CreateMap();
            player2.ShowMap();
            

        }
    }
}
