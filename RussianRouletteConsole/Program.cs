using System;
namespace RussianRoulette
{
    class RussianRouletteExtensions
    {
        static void Main()
        {
            string[] args = { "Alfred", "Nicolas", "Jimmy", "Sammuel", "Richard" };
            foreach (string lucker in args)
            {
            }

            var gun = new Gun();
            gun.ReloadIfEmpty();
            while (gun.Fire() == false)
            {
                Console.WriteLine("Clatz");
            }
            Console.WriteLine("Ba-Bahhhh");
            Console.ReadLine();
        }
    }
}
