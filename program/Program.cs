using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);

            /* positive a = new positive();
             a.main();

             num.number();

            @as.As();*/

            //marklist.list();
            //Console.ReadKey();

            /*duplicateelements.element();

            var userObj = new UserDetail();

            userObj.Email = "sureshkumar.duraisamy@gmail.com";
            userObj.FirstName = "Suresh";
            userObj.SecondName = "Kumar";

           var userObj1 = new UserDetail();

            userObj1.FirstName = "testtest";
            userObj1.SecondName = "test";
            userObj1.Email = "test@test.co";

            var lst = new List<UserDetail>();

            lst.Add(userObj);
            lst.Add(userObj1);

           var result =  lst.Where(x => x.Email == "test@test.co" );

           eligibility.Eligibility(userObj); 

            eligibility.Eligibility(lst); */
        }
    }
}
