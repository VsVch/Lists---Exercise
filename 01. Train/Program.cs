using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> waggons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string comands = Console.ReadLine();
            while (comands != "end")
            {
                string[] tokens = comands.Split();
                if (tokens.Length == 2)
                {
                    int currentWaggon = int.Parse(tokens[1]);
                    waggons.Add(currentWaggon);
                }
                else
                {
                    int currentCapacity = int.Parse(tokens[0]);
                    FindWagons(waggons, maxCapacity, currentCapacity);
                }


                comands = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", waggons));
            
        }

        private static void FindWagons(List<int> waggons, int maxCapacity, int currentCapacity)
        {
            for (int i = 0; i < waggons.Count; i++)
            {
                
                if (waggons[i] + currentCapacity <= maxCapacity)
                {
                    waggons[i] += currentCapacity;
                    //currentWaggon += currentWaggon;
                    break;
                }
            }
        }
    }
}
