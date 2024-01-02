using System;

namespace ReadingAMatrixFromAConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.WriteLine("Matrix[{0},{1}]", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for(int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(" " + matrix[row,col]);
                }
            }
              
           Console.ReadKey();
        }
    }
}
