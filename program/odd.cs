using System;


namespace program
{

    public class oddnum
    {
        public static void metodname()

        {
            Console.WriteLine("Odd numbers from 1 to 999. Prints one number per line.");
            for (int n = 1; n < (999 + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }

        }


    }
}

