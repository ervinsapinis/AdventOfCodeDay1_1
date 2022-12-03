using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDay1_1.Advent_of_code
{
    internal class Day2
    {
        public static void Run()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\code\adventOfCode\task2.txt");
            var totalScore = 0;
            

            foreach (var round in lines)
            {
                totalScore = totalScore + GetRoundResultScore(round);
            }

            Console.WriteLine(totalScore);
        }

        public static int GetRoundResultScore(string input)
        {
            if (input[2] == 'Y')
                return Paper(input[0]);
            if (input[2] == 'X')
                return Rock(input[0]);
            return Scissors(input[0]);
        }

        public static int Rock(char input)
        {
            if (input == 'C')
                return 7;
            else if (input == 'A')
                return 4;
            else return 1;
        }
        public static int Paper(char input)
        {
            if (input == 'A')
                return 8;
            else if (input == 'B')
                return 5;
            else return 2;
        }
        public static int Scissors(char input)
        {
            if (input == 'B')
                return 9;
            else if (input == 'C')
                return 6;
            else return 3;
        }

    }
}
