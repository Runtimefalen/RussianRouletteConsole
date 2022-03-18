using System;
namespace RussianRoulette
{
    class RussianRouletteExtensions
    {
        static void Main()
        {
            string[] args = { "Alfred", "Nicolas", "Jimmy", "Sammuel", "Richard" };
            
            var gun = new Gun();
            gun.ReloadIfEmpty();
            for (int i = 0; i < args.Length; i++)
            {
                if (gun.Fire() == false)
                {
                    Console.WriteLine("Clatz");
                }
                else
                {
                    Console.WriteLine("Player {0} was killed now!!!", args[i]);
                    Console.ReadLine();
                    string killedPlayer = args[i];
                    
                }
            }

            
                
            
        }
    }
}
