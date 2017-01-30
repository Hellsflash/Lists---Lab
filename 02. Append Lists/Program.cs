using System;
using System.Collections.Generic;

namespace _02.Append_Lists
{
    public class Program
    {
        public static void Main()
        {

            List<string[]> input = new List<string[]>();
            string[] seqs = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = seqs.Length - 1; i >= 0; i--)
            {
                string[] sequence = seqs[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                input.Add(sequence);
            }
            foreach (var sequence in input)
                Console.Write("{0} ", string.Join(" ", sequence));

        }
    }
}
