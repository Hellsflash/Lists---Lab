using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Square_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squares = new List<int>();


            foreach (var num in numbers)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squares.Add(num);
                    squares.Sort((a, b) => b.CompareTo(a));

                }

            }
            Console.WriteLine(string.Join(" ",squares));

        }

    }
}


