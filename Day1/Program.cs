using System;
using System.IO;
using System.Linq;

namespace Day1
{
    internal class Program
    {
        static void task1()
        {
            string[] numbers = System.IO.File.ReadAllLines("..\\..\\..\\input1.txt");
            int count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (Convert.ToInt32(numbers[i + 1]) > Convert.ToInt32(numbers[i]))
                {
                    count++;
                }
            }

            Console.WriteLine($"There are {count} increments");
        }

        static void task2()
        {
            string[] numbers = System.IO.File.ReadAllLines("..\\..\\..\\input1.txt");
            // Console.WriteLine(numbers[0]);
            int count = 0;
            for (int i = 0; i < numbers.Length - 3; i++)
            {
                int sum1 = Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[i + 1]) + Convert.ToInt32(numbers[i + 2]);
                int sum2 = Convert.ToInt32(numbers[i + 1]) + Convert.ToInt32(numbers[i + 2]) + Convert.ToInt32(numbers[i + 3]);
                if (sum2 > sum1)
                {
                    count++;
                }
            }

            Console.WriteLine($"There are {count} sum increments");
        }
        static void Main(string[] args)
        {
            task1();
            task2();
        }
    }
}
