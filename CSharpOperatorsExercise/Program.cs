using System;

namespace CSharpOperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            // a /= 4;

            //Console.WriteLine(a);

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

        }
    }
}
