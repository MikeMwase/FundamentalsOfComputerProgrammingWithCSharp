using System;

namespace Trinagle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "*";

            string output = "";

            for (int i = 0; i < 5; i++) 
            {
               for(int j = 5; j < 6; j++) 
               {
                   output += input;

                   Console.WriteLine(output);
               }
            }
        }
    }
}
