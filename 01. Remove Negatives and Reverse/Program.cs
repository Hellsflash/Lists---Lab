using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Remove_Negatives_and_Reverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).Reverse().ToList();

            var number = new List<int>();

            foreach (var num in listOfNumbers)
            {
                if (num > 0)
                {
                    number.Add(num);
                }
            }
            if (number.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", number));
            }
        }

    }

}


