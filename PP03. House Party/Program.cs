using System;
using System.Collections.Generic;
using System.Linq;

namespace PP03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                List<string> inputs = input.Split().ToList();

                if (inputs[2] == "going!")
                {
                    if (names.Contains(inputs[0]))
                    {
                        Console.WriteLine($"{inputs[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(inputs[0]);
                    }
                }
                if (inputs[2] == "not")
                {
                    if (names.Contains(inputs[0]))
                    {
                        names.Remove(inputs[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{inputs[0]} is not in the list!");
                    }
                }

            }

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }


        }
    }
}
