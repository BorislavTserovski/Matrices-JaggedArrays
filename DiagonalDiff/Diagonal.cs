using System;
using System.Collections.Generic;
using System.Linq;


namespace DiagonalDiff
{
    class Diagonal
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double[][]matrix = new double[n][];
            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }
            double firstDiagonal = 0;
           double secondDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                firstDiagonal += matrix[row][row];
            }
            int col = 0;
            for (int row = n-1; row >= 0; row--)
            {
                secondDiagonal += matrix[row][col];
                col++;
            }
            
            Console.WriteLine(Math.Abs(firstDiagonal-secondDiagonal));
        }
    }
}
