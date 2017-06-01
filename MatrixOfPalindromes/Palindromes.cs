using System;
using System.Collections.Generic;
using System.Linq;


namespace MatrixOfPalindromes
{
    class Palindromes
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string[][]matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{alphabet[row]}{alphabet[row+col]}{alphabet[row]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
