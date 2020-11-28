using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 1, 2, 3, 5, 8 };
            for (int i = 0; i < myArray.Length; i+=2)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
