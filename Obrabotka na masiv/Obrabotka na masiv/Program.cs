using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Obrabotka_na_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine(OprtionsManager.CountLess100(arr));
            Console.WriteLine(OprtionsManager.MaxNum(arr));
            arr = OprtionsManager.ReverseArr(arr);
            OprtionsManager.PrintArr(arr);
        }
    }
}
