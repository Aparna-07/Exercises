using System;

namespace Exercises
{
    internal class Class5
    {
        public static void Main2()
        {
            Console.Write("Input the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
           
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine($"First number : {a}");
            Console.WriteLine($"Second number : {b}");

            Console.ReadKey();
        }
    }
}
