using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class boolean
    {
        static void main()
        {

            int[] array = { 10, 20, 10, 30, 20, 40, 50, 50 };
            int numDups = 0, prevIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool foundDup = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        foundDup = true;
                        numDups++; // Increment means Count for Duplicate found in array.
                        break;
                    }
                }

                if (foundDup == false)
                {
                    array[prevIndex] = array[i];
                    prevIndex++;
                }
            }

            // Just Duplicate records replce by zero.
            for (int k = 1; k <= numDups; k++)
            {
                array[array.Length - k] = '\0';
            }


            Console.WriteLine("Console program for Remove duplicates from array.");
            Console.Read();
        }
    }
}
