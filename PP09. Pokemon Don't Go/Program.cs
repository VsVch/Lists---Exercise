using System;
using System.Collections.Generic;
using System.Linq;

namespace PP09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            while (numbers.Count > 0)
            {

                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int remove = numbers[0];
                    sum += remove;
                    numbers[0] = numbers[numbers.Count - 1];

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= remove)
                        {
                            numbers[i] += remove;
                        }
                        else
                        {
                            numbers[i] -= remove;
                        }

                    }

                }
                else if (index >= numbers.Count)
                {
                    int remove2 = numbers[numbers.Count - 1];
                    sum += remove2;
                    numbers[numbers.Count - 1] = numbers[0];

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= remove2)
                        {
                            numbers[i] += remove2;
                        }
                        else
                        {
                            numbers[i] -= remove2;
                        }



                    }

                }
                else
                {
                    int remove3 = numbers[index];
                    sum += remove3;
                    numbers.RemoveAt(index);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= remove3)
                        {
                            numbers[i] += remove3;
                        }
                        else
                        {
                            numbers[i] -= remove3;
                        }


                    }

                }



            }
            Console.WriteLine(sum);
        }
    }
}
