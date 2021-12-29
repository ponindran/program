using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class duplicateelements
    {
        public static void element()
        {
            int num, i,j;
            Console.Write("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            for (i = 0; i < num;i++)
            {
                for (j = i + 1; j <num;j++)
                {
                    if (arr[i] == arr[j])
                        
                        
                    Console.WriteLine(arr[i]);
                }
            }
            
            


        }


            
    }
}
