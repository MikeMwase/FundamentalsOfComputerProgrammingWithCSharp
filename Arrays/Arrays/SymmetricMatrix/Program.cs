using System;

namespace SymmetricMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows of the matrix");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns of the matrix");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.WriteLine("matrix[{0},{1}]", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            bool symmetric = true;
            for(int row = 0; row < matrix.GetLength(0) - 1 / 2; row++)
            {
                for(int col = 0; col < matrix.GetLength(1) - 1 / 2; col++)
                {
                    if (matrix[row,col] != matrix[rows - row -1,cols - col -1])
                    {
                        symmetric = false;
                        break;
                    }
                                     
                }
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
