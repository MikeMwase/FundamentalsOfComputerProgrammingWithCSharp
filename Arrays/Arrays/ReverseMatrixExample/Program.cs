using System;

namespace ReverseMatrixExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows of the matrix");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns of the matrix");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows,cols];

            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < cols; col++)
                {
                    Console.WriteLine("matrix[{0},{1}]",row,col);
                    matrix[row,col] = int.Parse(Console.ReadLine());
                }
            }

            for(int row = 0; row < matrix.GetLength(0); row++) 
            {
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
            }

            Console.WriteLine();

            int Rows = matrix.GetLength(0);

            int Cols = matrix.GetLength(1);

            int[,] reversedMatrix = new int[Rows,Cols];

            for(int row = 0; row < Rows; row++)
            {
                for(int col = 0; col < Cols; col++)
                {
                    reversedMatrix[Rows - row - 1,Cols - col - 1] = matrix[row,col];
                }
            }

            for(int row = 0; row < reversedMatrix.GetLength(0); row++)
            {
                for (int col = 0;col < reversedMatrix.GetLength(1);col++)
                {
                    Console.Write(reversedMatrix[row,col] + " ");
                }
            }

            Console.ReadKey();

        }
    }
}
