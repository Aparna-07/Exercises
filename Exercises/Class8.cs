using System;

namespace Exercises
{
    internal class Class8
    {
        public static void Main2()
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num*i}");
            }
            Console.ReadKey();
        }
    }
}
