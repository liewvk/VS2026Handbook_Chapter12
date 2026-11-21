
using System;
using System.Linq;

namespace VS2026Handbook_Ch12
{
    internal class sales
    {
        static void Main(string[] args)
        {
            double[] sales = { 1250, 1420, 950, 1730, 1610 };

            Console.WriteLine($"Total: RM{sales.Sum():F2}");

            Console.WriteLine($"Average: RM{sales.Average():F2}");

            Console.WriteLine($"Best month: RM{sales.Max():F2}");
        }
    }
}


