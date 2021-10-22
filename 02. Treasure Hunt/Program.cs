using System;
using System.Linq;

namespace _02._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {          //Първоначална кръв
            const double MAX_HEALTH = 100;
            double health = 100;
            double bitcoins = 0;
            string[] rooms = Console.ReadLine().Split('|').ToArray();

            for (int i = 0; i < rooms.Length; i++)
            {

                string[] commands = rooms[i].Split(" ").ToArray();
                if (commands[0] == "chest")
                {
                    double amount = double.Parse(commands[1]);
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                    continue;
                }
                if (commands[0] == "potion")
                {

                    double potion = double.Parse(commands[1]);
                    double damageTaken = MAX_HEALTH - health;
                    if (health + potion > MAX_HEALTH)
                    {
                        double diffhealth = health - MAX_HEALTH;
                        Console.WriteLine($"You healed for {damageTaken} hp.");
                        health = MAX_HEALTH;
                    }
                    else
                    {
                        health += potion;
                        Console.WriteLine($"You healed for {potion} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                    continue;

                }
                health -= double.Parse(commands[1]);
                if (health > 0)
                {

                    Console.WriteLine($"You slayed {commands[0]}.");

                }
                else
                {
                    Console.WriteLine($"You died! Killed by {commands[0]}.");
                    Console.WriteLine($"Best room: {i + 1}");
                    return;
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
