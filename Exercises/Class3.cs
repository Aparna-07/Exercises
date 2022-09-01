using System;

namespace Exercises
{
    internal class Class3
    {
        public static void Main2()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Quotient is {a / b}");

            Console.ReadKey();
        }
    }
}
