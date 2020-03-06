using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith("L")
            select fruit;

            foreach (var fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            // Which of the following numbers are multiples of 4 or 6
            var numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            /*
                Use the IEnumerable Where() method to build a new array of
                numbers that match two conditions. Then chain the OrderBy()
                method to order them ascending
            */
            var fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0).OrderBy(n => n);
            foreach (var n in fourSixMultiples)
            {
                Console.WriteLine(n);
            }

            /*
                Use All() to see if every item in the collection passes the
                provided conditions.
            */
            var allBetweenLarge = numbers.All(n => n > -100 && n < 400); // true
            var allBetweenSmall = numbers.All(n => n > -5 && n < 39); // false

        }
    }
}