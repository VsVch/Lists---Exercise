using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPleyer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPleyer = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            while (firstPleyer.Count != 0 && secondPleyer.Count != 0)
            {
                if (firstPleyer[0] > secondPleyer[0])
                {
                    firstPleyer.Add(firstPleyer[0]);
                    firstPleyer.Add(secondPleyer[0]);
                }
                else if (firstPleyer[0] < secondPleyer[0])
                {
                    secondPleyer.Add(secondPleyer[0]);
                    secondPleyer.Add(firstPleyer[0]);
                }
                else 
                {

                }
                firstPleyer.Remove(firstPleyer[0]);
                secondPleyer.Remove(secondPleyer[0]);

                if (firstPleyer.Count == 0)
                {
                    sum = secondPleyer.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");

                }
                else if (secondPleyer.Count == 0)
                {
                    sum = firstPleyer.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                }
                

            }
           
        }
    }
}
