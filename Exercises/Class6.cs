using System;

namespace Exercises
{
    internal class Class6
    {
        public static void Main2()
        {
            Console.Write("Input the first number to multiply: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} * {b} * {c} = {a*b*c}");
            Console.ReadKey();
        }
    }
}
