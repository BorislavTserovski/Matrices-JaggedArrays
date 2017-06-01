using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSumSquares
{
    class Startup
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[][]matrix = new int[rows][]; 
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            int maxSum = int.MinValue;
            int[]maxRow = new int[2];
            int[]maxCol = new int[2];
            for (int row = 0; row < rows -1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int currentSum = matrix[row][col] + matrix[row][col + 1]
                                     + matrix[row + 1][col] + matrix[row + 1][col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow[0] = matrix[row][col];
                        maxRow[1] = matrix[row][col + 1];
                        maxCol[0] = matrix[row + 1][col];
                        maxCol[1] = matrix[row + 1][col+1];
                    }
                }
            }
            Console.WriteLine(string.Join(" ",maxRow));
            Console.WriteLine(string.Join(" ", maxCol));
            Console.WriteLine(maxSum);


        }
    }
}
