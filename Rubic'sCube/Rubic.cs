using System;
using System.Collections.Generic;
using System.Linq;


namespace Rubic_sCube
{
    class Rubic
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[][] matrix = new int[rows][];
            
            int commands = int.Parse(Console.ReadLine());
            int k = 0;
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = k + 1;
                    k++;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int element = int.Parse(input[0]);
                string direction = input[1];
                int places = int.Parse(input[2]);
               
                switch (direction)
                {
                    case "up":
                        MoveUp(matrix, element, places );
                        break;
                    case "down":
                        MoveUp(matrix, element,rows - places % rows);
                        break;
                    case "right":
                        MoveRight(matrix, element, places);
                        break;
                    case "left":
                        MoveRight(matrix, element,cols -  places % cols);
                        break;
                }
            }
            var el = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row][col]==el)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int r = 0; r < matrix.Length; r++)
                        {
                            for (int c = 0; c < matrix[0].Length; c++)
                            {
                                if (matrix[r][c]==el)
                                {
                                    var current = matrix[row][col];
                                    matrix[row][col] = el;
                                    matrix[r][c] = current;
                                    Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                    break;
                                }
                                
                            }
                            
                        }
                        
                    }

                    el++;
                }
               
            }



            
        }

        private static void MoveRight(int[][] matrix, int element, int places)
        {
            var temp = new int[matrix[0].Length];
            for (int i = 0; i < matrix[0].Length; i++)
            {
                temp[i] = matrix[element][(i+ places) % matrix[0].Length];
            }
            matrix[element] = temp;
        }

        private static void MoveUp(int[][] matrix, int element, int moves)
        {
           int[] temp = new int[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                temp[i] = matrix[(i+moves) % matrix.Length][element];
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][element] = temp[i];
            }







        }
    }
}
