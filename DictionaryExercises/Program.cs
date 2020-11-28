using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int newID;
            string input;

            Console.WriteLine("Enter ID Number (or ENTER to finish): ");

            // Get student names and grades
            do
            {
                Console.WriteLine("ID: ");
                input = Console.ReadLine();
                

                if (!Equals(input, ""))
                {
                    newID = int.Parse(input);
                    Console.WriteLine("Name: ");
                   string newName = Console.ReadLine();
                    students.Add(newID, newName);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(input, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
                
            }
        }
    }
}
