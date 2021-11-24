using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class positive
    {
        public void main()
        {
            int i;
            Console.WriteLine("Enter the number:");
            i = int.Parse(Console.ReadLine());

            if (i >= 0)
            {
                Console.WriteLine("The num is positive number");
            }
            else
            {
                Console.WriteLine("The num is negative number");
            }
        }

    }
}


