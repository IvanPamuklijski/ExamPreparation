using System;

namespace _04._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FOOD_FOR_EACH_DAY = 300;


            double quanityOfFood = double.Parse(Console.ReadLine());
            double quanityHay = double.Parse(Console.ReadLine());
            double quanityCover = double.Parse(Console.ReadLine());
            double guineasWeight = double.Parse(Console.ReadLine());

            double foodInGrams = quanityOfFood * 1000;
            double hayInGrams = quanityHay * 1000;
            double coverInGrams = quanityCover * 1000;
            double guinesGrams = guineasWeight * 1000;

            for (int days = 1; days <= 30; days++)
            {
                foodInGrams -= FOOD_FOR_EACH_DAY;
                if (days % 2 == 0)
                {
                    hayInGrams -= foodInGrams * 0.05;
                }
                if (days % 3 == 0)
                {
                    coverInGrams -= guinesGrams / 3;
                }
                if (foodInGrams <= 0 || hayInGrams <= 0 || coverInGrams <= 0)
                {
                    break;
                }

            }
            if (foodInGrams > 0 && hayInGrams > 0 && coverInGrams > 0)
            {

                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInGrams / 1000:f2}, Hay: {hayInGrams / 1000:f2}, Cover: {coverInGrams / 1000:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");

            }







        }
    }
}
