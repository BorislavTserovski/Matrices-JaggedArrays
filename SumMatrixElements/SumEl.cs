using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMatrixElements
{
    class SumEl
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[][]matrice = new int[rows][];
            
            for (int row = 0; row < rows; row++)
            {
                matrice[row] = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                
                for (int col = 0; col < cols; col++)
                {
                    sum += matrice[row][col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);

          


        }
    }
}
