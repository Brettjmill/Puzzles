using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static void RandomArray()
        {
            Random rand = new Random();
            int[] newArr = new int[10];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = rand.Next(5,26);
            }

            var min = newArr[0];
            var max = newArr[0];
            var sumTotal = 0;

            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] < min)
                {
                    min = newArr[i];
                }
                else if (newArr[i] > max)
                {
                    max = newArr[i];
                }
                sumTotal += newArr[i];
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sumTotal);
        }

        public static string TossCoin()
        {
            Random rand = new Random();

            var coinResult = 0;

            Console.WriteLine("Tossing a coin!");

            coinResult = rand.Next(1,3);

            if (coinResult == 1)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }

        public static double TossMultipleCoins(int num)
        {
            double headsTracker = 0;
            for (int i = 0; i < num; i++)
            {
                if (TossCoin() == "Heads")
                {
                    headsTracker++;
                }
            }
            return headsTracker/num;
        }

        public static List<string> Names()
        {
            Random rand = new Random();

            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");

            for (int i = 0; i < names.Count; i++)
            {
                var temp = rand.Next(0,names.Count);
                var tempName = names[i];
                names[i] = names[temp];
                names[temp] = tempName;
            }

            Console.WriteLine("[{0}]", string.Join(", ", names));

            List<string> newNames = new List<string>();
            
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Length > 5)
                {
                    newNames.Add(names[i]);
                }
            }

            return newNames;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("[{0}]", string.Join(", ", Names()));
        }
    }
}
