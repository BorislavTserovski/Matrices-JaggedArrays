using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumSum
{
    class Sum
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[][]matrix = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            int max = int.MinValue;

            int[] firstRow = new int[3];
            int[] secondRow = new int[3];
            int[] thirdRow = new int[3];
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols -2; col++)
                {
                    if (matrix[row][col]+matrix[row][col+1]+matrix[row][col+2]
                        +matrix[row+1][col]+matrix[row+1][col+1]+matrix[row+1][col+2]
                        +matrix[row+2][col]+matrix[row+2][col+1]+matrix[row+2][col+2]>max)
                    {
                        max = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2]
                              + matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2]
                              + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                         firstRow =new int[]{ matrix[row][col] , matrix[row][col + 1] , matrix[row][col + 2] } ;
                         secondRow = new int[]{ matrix[row + 1][col] , matrix[row + 1][col + 1] , matrix[row + 1][col + 2] };
                         thirdRow = new int[]{ matrix[row + 2][col] , matrix[row + 2][col + 1] , matrix[row + 2][col + 2] };
                    }
                }
               
            }
            Console.WriteLine($"Sum = {max}");
            Console.WriteLine(string.Join(" ",firstRow));
            Console.WriteLine(string.Join(" ", secondRow));
            Console.WriteLine(string.Join(" ", thirdRow));
            
           

        }
    }
}
