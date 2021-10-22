using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            int cupidPosition = 0;
            string command = Console.ReadLine();

            while (command != "Love!")
            {
                string[] commandSplited = command.Split();
                //["jump" , "1"]
                //cmdSplited[0] = jump
                int jump = int.Parse(commandSplited[1]);
                if (cupidPosition + jump >= neighborhood.Length)
                {
                    cupidPosition = 0;
                }
                else
                {
                    cupidPosition += jump;
                }
                neighborhood[cupidPosition] -= 2;
                if (neighborhood[cupidPosition] == 0)
                {
                    Console.WriteLine($"Place {cupidPosition} has Valentine's day.");
                }
                if (neighborhood[cupidPosition] < 0)
                {
                    Console.WriteLine($"Place {cupidPosition} already had Valentine's day.");
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {cupidPosition}.");
            if (!neighborhood.Any(x => x > 0))
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {                                       //[10,0,10,0,10].count(number  => number > 0 == 3)
                Console.WriteLine($"Cupid has failed {neighborhood.Count(x => x > 0)} places.");
            }


        }
    }
}
