using System;

namespace SymetricArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive value for the length of your array");

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter the values of the array");

            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if(n == 0)
                {
                    Console.WriteLine("The list has been populated");
                    break;
                }
            }

            bool symmetric = true;

            for (int i = 0; i < (n - 1) / 2; i++) 
            {
                if (array[i] != array[n-i-1])
                {
                    symmetric = false;
                    Console.WriteLine("Array is not symmetric");
                    break;
                }
        
            }

            Console.WriteLine("The Array is symmetric");

            Console.ReadKey();
        }
    }
}
