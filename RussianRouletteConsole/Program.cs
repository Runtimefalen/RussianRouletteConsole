using System;
namespace RussianRoulette
{
    class RussianRouletteExtensions
    {
        static void Main()
        {

            ///see this text
            var players = new List<string> { "Alfred", "Nicky", "JiJimmy", "Sammuel", "RicRichard" };
            var gun = new Gun();
            int roundNumber = 1;
            
            Console.WriteLine("Game players {0}",string.Join(", ", players));
            while (players.Count > 1)
            {
                Console.WriteLine("GAME {0} is started", roundNumber++);
                gun.ReloadIfEmpty();
                for (int i = 0; i < players.Count; i++)
                {
                    string selectedPlayer = players[i];
                    if (gun.Fire())
                    {
                        Console.WriteLine("Player {0} was KILLED now!!!", selectedPlayer);
                        players.Remove(selectedPlayer);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} tz", selectedPlayer);
                    }
                }
                if (players.Count>1)
                {
                Console.Write("Go to the {0} game: {1}", roundNumber, string.Join(", ", players));
                }
                Console.WriteLine();
                Console.ReadLine();
            }
            Console.Write("Winner of the game {0}!!!", players[0]);
            Console.ReadLine();
        }
    }
}
