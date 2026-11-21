
using System;
using System.Collections.Generic;
using System.Linq;

namespace VS2026Handbook_Ch12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new() { 80, 65, 90, 75 };

            double average = scores.Average();

            Console.WriteLine($"Average: {average:F1}");

            foreach (int score in scores)
            {
                Console.WriteLine(score >= 70 ? "Pass" : "Review");
            }
        }
    }
}

