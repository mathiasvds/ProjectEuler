using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var euler = new Euler1To50();

            Console.WriteLine(euler.MultiplesOf3And5());
            Console.ReadKey();
        }
    }
}
