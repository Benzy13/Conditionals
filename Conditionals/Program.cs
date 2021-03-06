﻿using System;

namespace Conditionals
{

    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("Lte's go to the beach!");
                    break;

                case Season.Winter:
                case Season.Spring:
                    Console.WriteLine("Promotion!");
                    break;

                default:
                    Console.WriteLine("I don't undersand that season.");
                    break;
            }
        }
    }
}
