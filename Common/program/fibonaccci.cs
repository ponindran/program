using System;

namespace program
{
    class series
    {
        public static void fib()
        {

            int a1 = 0, a2 = 1, a3, i, number;

            Console.Write("Enter the number of elements:");
            number = int.Parse(Console.ReadLine());

            Console.Write(a1 + " " + a2 + " ");

            for (i = 0; i < number; i++)
            {
                a3 = a1 + a2;
                Console.Write(a3 + " ");

                a1 = a2;
                a2 = a3;
            }
        }
    }
}



































