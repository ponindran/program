using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class @as
    {
        public void As()
        {
            int number, i, j;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());
            
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
