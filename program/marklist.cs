using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class marklist
    {
        public static void list()
        {
            double rno, mat, phy, che, total, per;
            string name;

            Console.WriteLine("Enter the roll num:");
            rno = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter the maths mark:");
            mat = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the phy mark:");
            phy = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the che mark:");
            che = double.Parse(Console.ReadLine());


            total = mat + phy + che;
            per = total / 3.0;

            

            
            Console.Write("\nRoll num: {0} \nName:{1} \n",rno, name);
            Console.Write("Mark in maths: {0} \n Mark in physics: {1} \nMark in chemistry: {2}\n", mat, phy, che);
            Console.Write("Total mark = {0} \npercentage= {1} \n",total,per);
        }
    }
}
