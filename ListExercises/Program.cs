using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string[] practiceNames = { "Andrea", "Erika", "Josie", "Maddie", "Zach", "Emersyn", "Blair", "Phil" };
            List<string> names = new List<string>(practiceNames);
           List<int> nums = new List<int>();
            nums.Add(2);
            nums.Add(4);
            nums.Add(7);
            nums.Add(13);
            nums.Add(8);
            nums.Add(9);
            nums.Add(1);
            nums.Add(3);
            nums.Add(33);
            nums.Add(22);
            foreach (int number in nums) 
            {
                if (IsEven(number))
                {
                    Console.WriteLine(number);
                }
            }

            Printnames(names);
        }

        static void Printnames(List<string> names)
        {
            Console.WriteLine("Number of letters: ");
            string input = Console.ReadLine();
            int numLetters = int.Parse(input);

            foreach (string name in names)
            {
                if (name.Length == numLetters)
                {
                    Console.WriteLine(name);
                }
            }
        }


    }
}
