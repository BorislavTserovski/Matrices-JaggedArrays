using System;
using System.Collections.Generic;
using System.Linq;


namespace LegoBlocks
{
    class Lego
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][]firstJagged = new int[n][];
            int[][]secondJagged = new int[n][];
           
            for (int row = 0; row < n; row++)
            {
                int[] inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                firstJagged[row] = inputLine;
            }
            for (int row = 0; row < n; row++)
            {
                int[] inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                secondJagged[row] = inputLine;
            }
           
            int[][]result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = firstJagged[i].Concat(secondJagged[i].Reverse()).ToArray();
            }
            int sum = 0;
            foreach (int[] row in result)
            {
                sum += row.Length;
            }
            if (isMatrix(firstJagged,secondJagged,n))
            {
                for (int row = 0; row < n/2; row++)
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        Console.Write("[");
                        Console.Write("{0}",string.Join(", ",result[i]));
                        Console.Write("]");
                        Console.WriteLine();
                    }
                    
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {sum}");
            }
            

        }

        private static bool isMatrix(int[][] first,int[][]second,int n)
        {
            int a = first[0].Length;
            int b = second[0].Length;
            int c = a + b;

            bool fitting = true;
       
            for (int i = 1; i < n; i++)
            {
                a = first[i].Length;
                b = second[i].Length;
                
                if (a + b != c)
                {
                    fitting = false;
                }
            }
            return fitting;
        }
    }
}
