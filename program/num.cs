using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class num
    {
        public static void number()
        {
            int num1 = 20;
            int num2 = 30;
            num1 = num1 + num2;
            num2 = num2 + num1;
            num1 = num1 - num2;
            Console.WriteLine(num1 + "," + num2);
        }
    }
}
