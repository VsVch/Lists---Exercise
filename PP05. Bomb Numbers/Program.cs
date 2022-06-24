using System;
using System.Collections.Generic;
using System.Linq;

namespace PP05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = (bombNumbers[0]);
            int number = (bombNumbers[1]);

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    for (int j = 1; j <= number; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i - j] = 0;
                        }
                    }
                    for (int k = 1; k <= number; k++)
                    {
                        if (i + k > numbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i + k] = 0;
                        }
                    }
                    numbers[i] = 0;
                }

            }
            


            for (int j = 0; j < numbers.Count; j++)
            {
                sum += numbers[j];
            }
            //Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(sum);
        }
    }
}
