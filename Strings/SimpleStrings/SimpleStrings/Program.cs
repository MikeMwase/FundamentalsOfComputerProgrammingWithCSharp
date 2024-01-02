using System;

namespace SimpleStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "This is a simple string message.";

            Console.WriteLine("message {0}", message);

            Console.WriteLine("message.Length {0}", message.Length);

            for (int i = 0; i < message.Length - 1; i++)
            {
                Console.WriteLine("Message[{0}] = {1}", i, message[i]);
            }
        }
    }
}
