using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDay1_1.Advent_of_code
{
    internal class Day3
    {
        public static void RunTask1()
        {
            Dictionary<char, int> priorities = new Dictionary<char, int>();
            for (int i = 'a'; i <= 'z'; i++)
            {
                priorities.Add((char)i, i - 'a' + 1);
            }
            for (int i = 'A'; i <= 'Z'; i++)
            {
                priorities.Add((char)i, i - 'A' + 27);
            }


            string[] lines = System.IO.File.ReadAllLines(@"D:\code\adventOfCode\task3.txt");
            var count = 0;
            foreach(var input in lines)
            {
                var compartment1 = input.Substring(0, input.Length / 2).ToCharArray();
                var compartment2 = input.Substring(input.Length / 2).ToCharArray();
                var commonChars = compartment1.Intersect(compartment2).ToArray();

                foreach (var commonChar in commonChars)
                {
                    priorities.TryGetValue(commonChar, out int value);
                    count += value;
                }    
                    
            }
             Console.WriteLine(count);

        }
    }
}
