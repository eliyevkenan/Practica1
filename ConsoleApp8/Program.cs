using Entities;
using System;
using Utils.Enums;
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Gta5", Platformenum.Pc, 4500);
            Game game1 = new Game("Sukran", Platformenum.PlayStation, 3000);
            Game game2 = new Game("Allahverdi", Platformenum.Xbox, 500);
            Store store = new Store();
            store.AddGame(game);
            store.AddGame(game1);
            store.AddGame(game2);
            foreach (var item in store)
            {
                Console.WriteLine(item);
            }
        }
    }
}
