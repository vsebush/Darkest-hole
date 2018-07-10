using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace level_designer
{
   static class Input
    {
       static string path = @"c:\tmp\";
       static lvlconstructor constr = new lvlconstructor();
       static string[] help = new string[] { "create", "help", "open" };
        static string line;
       
            public  static void maincycle ()
        {
            Console.WriteLine("create a new one / select the previous one");            
            bool i = false;
            while ( i == false )
            {
                line = Console.ReadLine();

                switch (line)
                {
                    
                    case "help":
                        Console.WriteLine("Comands : ");
                        foreach (string element in help)
                            Console.WriteLine(element);
                        break;
                    case "create":
                        Console.WriteLine("Enter name");
                        line = Console.ReadLine();
                        if (File.Exists(path + line + ".txt"))
                        { Console.WriteLine("file already exists"); }
                        else { path = path + line + ".txt"; constr.path = path ;i = true; }
                        break;

                }
            }












        }









    }
}
