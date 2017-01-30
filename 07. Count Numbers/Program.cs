using System;
using System.Linq;

namespace _07.Count_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var count = new int[number.Max() + 1];

            foreach (var  num in number)
            {
                count[num]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i]>0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }
    }
}
