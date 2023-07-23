using System;
using System.IO;

namespace Sec4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Student_data.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("Student Data:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Error: The student_data.txt file is missing.");
            }

            Console.ReadLine();
        }
    }
}
