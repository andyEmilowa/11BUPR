using System;
using System.Collections.Generic;
using System.Linq;

namespace zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if (command == "Print")
                {
                    switch(command)
                    {
                        case "add": var index = int.Parse(input[1]);
                            var element = int.Parse(input[2]);
                            nums.Insert(index, element);
                            break;

                        case "addMany":
                            3
                            break;

                        case "contains":
                            break;
                    }
                }
            }
        }
    }
}
