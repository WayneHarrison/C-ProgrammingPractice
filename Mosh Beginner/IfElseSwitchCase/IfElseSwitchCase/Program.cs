using System;

namespace IfElseSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }

            float price2 = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
            Console.WriteLine(price2);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("It's promotion time!");
                    break;
                default:
                    Console.WriteLine("I don't understand.");
                    break;
                
            }

        }
    }
}
