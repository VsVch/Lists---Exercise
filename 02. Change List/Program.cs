using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = Console.ReadLine();
            while (line != "end")
            {
                

                string[] tokens = line.Split();
                string command = tokens[0];
                int element = int.Parse(tokens[1]);
                //Console.WriteLine(element);

                if (command == "Delete")
                {
                    listOfIntegers.RemoveAll(x => x == element);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    listOfIntegers.Insert(index, element);
                }



                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listOfIntegers));
        }

    }
}