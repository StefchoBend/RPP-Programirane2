using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulation
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
                if (command == "print")
                {
                    break;
                }
                switch (command)
                {
                    case "add":
                        break;
                    case "addMany":
                        break;
                    case "contains":
                        break;
                    case "remove":
                        break;
                    case "shift":
                        break;
                    case "sumPairs":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
