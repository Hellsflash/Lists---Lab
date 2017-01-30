using System;
using System.Linq;

namespace _05.Sort_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < number.Count; i++)
            {
                number.Sort();
                Console.Write("<=");
                Console.Write(number[i]);
            }

            Console.WriteLine();
        }
    }
}
