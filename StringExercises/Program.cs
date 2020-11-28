using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string practiceString = "I would not, could not, in a box. I would not, could not with a fox.I will not eat them in a house. I will not eat them with a mouse.";
            string[] practiceArray = practiceString.Split(' ');
            Console.WriteLine(string.Join(",", practiceArray));
            string[] sentence = practiceString.Split('.');
            Console.WriteLine(string.Join("-", sentence));
        }
    }
}
