using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Ivan", 30);
            Console.WriteLine(hero);

            BladeKnight knight = new BladeKnight("Niki", 28);
            Console.WriteLine(knight);
        }
    }
}
