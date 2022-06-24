using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        
                        if (int.Parse(command[2]) < numbers.Count && int.Parse(command[2]) >= 0)
                        {
                            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine($"Invalid index");
                        }
                        
                        break;
                    case "Remove":

                        int task = int.Parse(command[1]);
                        if (task >= 0 && task < numbers.Count)
                        {
                            numbers.RemoveAt(task);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }



                        break;
                    case "Shift":
                        int count = int.Parse(command[2]);
                        if (command[1] == "left")
                        {
                            while (count != 0)
                            {
                                int cur = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(cur);

                                count--;
                            }

                            
                        }
                        else
                        {
                            
                            {
                                while (count != 0)
                                {
                                    int cur = numbers[numbers.Count - 1];
                                    numbers.RemoveAt(numbers.Count-1);
                                    numbers.Insert(0, cur);

                                    count--;
                                }


                            }
                        }
                        break;
                    

                    default:
                        break;
                }




                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
