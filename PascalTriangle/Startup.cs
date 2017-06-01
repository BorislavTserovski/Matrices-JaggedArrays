using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long[][]triangle = new long[n+1][];

            for (int row = 0; row < n; row++)
            {
                triangle[row] = new long[row+1];
            }

            triangle[0][0] = 1;
            for (int row = 0; row < n-1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];

                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0} ",triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
