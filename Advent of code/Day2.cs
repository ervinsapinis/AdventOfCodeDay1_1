using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDay1_1.Advent_of_code
{
    internal class Day2
    {
        public static void RunTask1()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\code\adventOfCode\task2.txt");
            var totalScore = 0;


            foreach (var round in lines)
            {
                totalScore += GetRoundResultScore(round);
            }

            Console.WriteLine(totalScore);
        }
        public static void RunTask2()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\code\adventOfCode\task2.txt");
            //string[] lines = { "A Y", "B X", "C Z" };
            var totalScore = 0;


            foreach (var round in lines)
            {
                totalScore += GetSchemeScore(round);
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
        public static int GetSchemeScore(string input)
        {
            if (input[2] == 'X')
                return Lose(input[0]);
            else if (input[2] == 'Y')
                return Draw(input[0]);
            else return Win(input[0]);
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

        public static int Win(char input)
        {
            if (input == 'C')
                return Rock(input);
            else if (input == 'A')
                return Paper(input);
            else return Scissors(input);
        }
        public static int Draw(char input)
        {
            if (input == 'A')
                return Rock(input);
            else if (input == 'B')
                return Paper(input);
            else return Scissors(input);
        }
        public static int Lose(char input)
        {
            if (input == 'B')
                return Rock(input);
            else if (input == 'C')
                return Paper(input);
            else return Scissors(input);
        }
    }
}
