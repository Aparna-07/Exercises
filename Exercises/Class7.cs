using System;

namespace Exercises
{
    internal class Class7
    {
        public static void Main()
        {
            Console.Write("Input the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
            
            Console.ReadKey();
        }
    }
}
