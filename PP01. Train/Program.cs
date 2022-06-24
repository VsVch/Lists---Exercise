using System;
using System.Collections.Generic;
using System.Linq;

namespace PP01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split();

                if (command.Length > 1)
                {
                    listWagons.Add(int.Parse(command[1]));
                }
                if (command.Length == 1)
                {
                    for (int i = 0; i < listWagons.Count; i++)
                    {
                        if (maxCapacity >= (listWagons[i] + int.Parse(command[0])))
                        {
                            listWagons[i] = listWagons[i] + int.Parse(command[0]);
                            break;
                        }

                    }
                }

                input = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", listWagons));
        }
    }
}
