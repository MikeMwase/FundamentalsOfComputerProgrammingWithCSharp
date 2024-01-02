using System;

namespace ArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 4, 3, 2, 1};

            int length = array.Length;

            int[] reversedArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }

            for(int i = 0; i < length; i++)
            {
                reversedArray[length - 1 - i] = array[i];
            }

            Console.WriteLine();

            for(int i = 0; i < length; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }
            
            Console.ReadKey();
        }
    }
}
