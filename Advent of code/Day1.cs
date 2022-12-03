using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDay1_1.Advent_of_code
{
    internal class Day1
    {
        public static void Run()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\code\adventOfCode\task1.txt");
            var sumList = new List<int>();
            int tempSum = 0;

            foreach (string line in lines)
            {
                if (line != "")
                {
                    tempSum = tempSum + int.Parse(line);
                }
                else
                {
                    sumList.Add(tempSum);
                    tempSum = 0;
                }
            }

            Console.WriteLine(sumList.Count);
            Console.WriteLine("Now writing all sums");
            foreach (int sum in sumList)
                Console.WriteLine(sum);

            Console.WriteLine();
            Console.WriteLine(sumList.Max());

            var topThree = sumList.OrderByDescending(p => p).Take(3).Sum();
            Console.WriteLine();
            Console.WriteLine(topThree);
        }
    }
}
