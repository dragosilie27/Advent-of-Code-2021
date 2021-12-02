using System;

namespace Day2
{
    internal class Program
    {
        static void task()
        {
            string[] instructions = System.IO.File.ReadAllLines("..\\..\\..\\input2.txt");
            char separator = ' ';
            long hor = 0;
            long vert1 = 0, vert2 = 0;
            long aim = 0;
            foreach (var instruction in instructions)
            {
                string[] words = instruction.Split(separator);
                switch (words[0])
                {
                    case "forward":
                        hor += Convert.ToInt64(words[1]);
                        vert2 += aim * Convert.ToInt64(words[1]);    
                        break;
                    case "down":
                        vert1 += Convert.ToInt64(words[1]);
                        aim += Convert.ToInt64(words[1]);
                        break;
                    case "up":
                        vert1 -= Convert.ToInt64(words[1]);
                        aim -= Convert.ToInt64(words[1]);
                        break;
                    default:
                        break;
                }


            }
            long result1 = hor * vert1;
            long result2 = hor * vert2;


            Console.WriteLine($"The task 1 result is {result1} and task 2 results is {result2}");
        }
        static void Main(string[] args)
        {
            task();
        }
    }
}
