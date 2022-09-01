using System;

namespace Exercises
{
    internal class Class10
    {
        public static void Main2()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int result1 = (num1 + num2) * num3;
            int result2 = (num1 * num2) + (num2 * num3);
            Console.WriteLine($"Result of specified numbers {num1}, {num2} and {num3}, (x+y).z is {result1} and x.y +y.z is {result2}");
            Console.ReadKey();
        }
    }
}
