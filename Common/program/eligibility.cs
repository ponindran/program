using BusinessService;
using Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class eligibility
    {
        public static void Eligibility()
        {
            double mat, phy, che, total;

            Console.Write("Enter the maths mark:");
            mat = double.Parse(Console.ReadLine());

            Console.Write("Enter the phy mark:");
            phy = double.Parse(Console.ReadLine());

            Console.Write("Enter the che mark:");
            che = double.Parse(Console.ReadLine());

            total = mat + phy + che;
            total = mat + phy;
            total = mat + che;

            if (mat >= 65)
            {
                if (phy >= 55)
                {
                    if (che >= 50)
                    {
                        if (mat + phy + che >= 180)
                        {
                            Console.Write("\nTotal marks of Maths, Physics and Chemistry : {0}\n", mat + phy + che);
                            Console.Write("The  candidate is eligible for admission.\n");
                        }
                        else if (mat + phy >= 140)

                        {
                            Console.Write("Total marks of Maths and  Physics : {0}\n", mat + phy);
                            Console.Write("The  candidate is eligible for admission.\n");
                        }
                        else
                        {
                            Console.WriteLine("The  candidate is not eligible for admission.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The  candidate is not eligible for admission.\n");
                    }
                }
                else
                {
                    Console.WriteLine("The  candidate is not eligible for admission.\n");
                }
            }
            else
            {
                Console.WriteLine("The  candidate is not eligible for admission.\n");
            }

        } 


        public static void Eligibility(UserDetail user)
        {

            var obj = new Class1();

            obj.GetRandomUserDetail(user);

            Console.WriteLine(user.FirstName);
        }

        public static void Eligibility(List<UserDetail> user)
        {

           
        }
    }
}