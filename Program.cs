using System;
using System.Collections.Generic;
using System.Linq;

namespace Лаба_1._3__2_семестр_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of numbers:");
            var nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(9);
            nums.Add(-4);
            nums.Add(-3);
            nums.Add(-8);
            nums.Add(2);
            nums.Add(3);
            nums.Add(10);
            nums.Add(6);
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int count = nums.Count(x => x > 0);
            Console.WriteLine($"Amount of supplementary numbers: {count}");
            for (int i = 0; i < nums.Count; i++)
            { 
                if (nums[i] % 2 == 1 || nums[i]%2==-1 || nums[i]%2==0.5)
                {
                    nums.RemoveAt(i);
                }
            }
            Console.WriteLine("List of double numbers:");
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int sum=nums.Sum(x=> x );
            Console.WriteLine($"Summary of double numbers: {sum}");
            Console.ReadKey();
        }
    }
}
