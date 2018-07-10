using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace level_designer
{
    class Program
    {


        static void Main(string[] args)

        {

            lvlconstructor constructor = new lvlconstructor();
            constructor.path = @"c:\tmp\MyTest";
            constructor.create_place(1, 3, 2, 8);
            constructor.create_tetragon(9, 9);
            constructor.create_long_wall(1, 3, 2, 8);
            constructor.create_wall(9, 9, 10, 10);
            // constructor.create_wall(1, 1, 2, 1);
            constructor.record();

            Console.WriteLine("Done, your level is in   " + constructor.path);
            Console.WriteLine(" print any button to escape ...");

           // LvlReader read = new LvlReader(@"c:\tmp\MyTest");            
           // read.start();
            Level le = new Level(@"c:\tmp\MyTest");
            le.read1.start();


            for (int i = 0; i < le.read1.listtetragon.Count; i++)
            {
                Console.WriteLine(le.read1.listtetragon[i].getx() + " " + le.read1.listtetragon[i].gety());

            }

            Console.WriteLine("/////////////////////////////////");

            for (int i = 0; i < le.read1.listwall.Count; i++)
            {
                Console.WriteLine(le.read1.listwall[i].tetragon1.getx() + " " + le.read1.listwall[i].tetragon1.gety() + " " + le.read1.listwall[i].tetragon2.getx() + " " + le.read1.listwall[i].tetragon2.gety());
            }
            Console.WriteLine("/////////////////////////////////");

            for (int i = 0; i < le.read1.listheroes.Count; i++)
            {
                Console.WriteLine(le.read1.listheroes[i].name + " " + le.read1.listheroes[i].hp + " " + le.read1.listheroes[i].ap);
            }













































                Console.ReadLine();
        }
    }
}
