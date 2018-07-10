using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class lvlconstructor
    {
        List<Wall> listwall = new List<Wall>() ;
        List<Tetragon> listtetragon = new List<Tetragon>();
        MyMath.Worldposition position = new MyMath.Worldposition(0,0);
        int x;
        int y;
        string path = @"c:\tmp\MyTest.txt";
        string text;

        public void create_place(int x,int y)
        {
            position = new MyMath.Worldposition(x, y);
            listtetragon.Add(new Tetragon(position) );
        }
        public void create_tetragon()
        { }
        public void create_wall()
        { }
        public void create_long_wall()
        { }
        public void create_room()
        { }
        public void record()
        {
            
            for(int i = 0;i< listwall.Count;i++) {

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(listwall[i]);
                }
            }
            
        }








    }
}
