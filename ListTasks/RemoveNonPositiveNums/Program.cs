﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNonPositiveNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            nums.RemoveAll(t => t < 0);
            nums.Reverse();
            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", nums));
            }
        }
    }
}
