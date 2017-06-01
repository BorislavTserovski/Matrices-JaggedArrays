using System;
using System.Collections.Generic;
using System.Linq;


namespace GroupElements
{
    class Startup
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] zero = input.Where(n => Math.Abs(n) % 3 == 0).ToArray();
            int[] one = input.Where(n => Math.Abs(n) % 3 == 1).ToArray();
            int[] two = input.Where(n => Math.Abs(n) % 3 == 2).ToArray();
            Console.WriteLine(string.Join(" ",zero));
            Console.WriteLine(string.Join(" ", one));
            Console.WriteLine(string.Join(" ", two));
        }
    }
}
