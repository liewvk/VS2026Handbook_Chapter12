
using System;
using System.Linq;

namespace VS2026Handbook_Ch12
{
    internal class movingAverage
    {
        static void Main(string[] args)
        {
            int[] sales = { 10, 16, 14, 20 };

            for (int i = 2; i < sales.Length; i++)
            {
                Console.WriteLine(
                    $"Period {i + 1}: {sales.Skip(i - 2).Take(3).Average():F1}");
            }
        }
    }
}

