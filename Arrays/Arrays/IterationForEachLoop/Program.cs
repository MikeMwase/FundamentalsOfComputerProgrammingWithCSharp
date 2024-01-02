using System;

namespace IterationForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] capitals = {"Harare", "Maputo", "Gaborone", "Windhoek","Pretoria"};
            foreach(string capital in capitals)
            {
                Console.WriteLine(capital);
            }

            Console.ReadKey();
        }
    }
}
