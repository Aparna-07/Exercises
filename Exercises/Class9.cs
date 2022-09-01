using System;

namespace Exercises
{
    internal class Class9
    {
        public static void Main2()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            float average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", num1, num2, num3, num4, average);
            Console.ReadKey();
        }
    }
}
