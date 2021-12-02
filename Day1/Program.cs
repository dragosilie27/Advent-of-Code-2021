using System;
using System.IO;
using System.Linq;

namespace Day1
{
    internal class Program
    {
        static void Task1()
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

        static void Task2()
        {
            string[] numbers = System.IO.File.ReadAllLines("..\\..\\..\\input1.txt");
            int count = 0;
            for (int i = 0; i < numbers.Length - 3; i++)
            {
                if (Convert.ToInt32(numbers[i + 3]) > Convert.ToInt32(numbers[i]))
                {
                    count++;
                }
            }

            Console.WriteLine($"There are {count} sum increments");
        }
        static void Main()
        {
            Task1();
            Task2();
        }
    }
}
