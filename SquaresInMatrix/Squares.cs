using System;
using System.Collections.Generic;
using System.Linq;


namespace SquaresInMatrix
{
    class Squares
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            string[][]matrix = new string[rows][];
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            int counter = 0;
            for (int row = 0; row < rows-1 ; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    if (matrix[row][col].Equals(matrix[row+1][col])&&
                        matrix[row][col].Equals(matrix[row][col+1])
                        &&matrix[row][col].Equals(matrix[row+1][col+1]))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
