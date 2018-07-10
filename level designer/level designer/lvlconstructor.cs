using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//= @"c:\tmp\MyTest.txt"
namespace level_designer
{
    class lvlconstructor
    {
       public List<Wall> listwall = new List<Wall>() ;
       public List<Tetragon> listtetragon = new List<Tetragon>();
        Worldposition position = new Worldposition(0, 0);
        //MyMath.Worldposition position2 = new MyMath.Worldposition(0, 0);
        int x;
        int y;
       public string path;
        string text;

        
        public void create_tetragon (int x,int y)
        {
            position = new Worldposition(x, y);
            listtetragon.Add(new Tetragon(position) );
        }
        public void create_place(int x, int y, int x2, int y2)
        {
           
            for (int i = x;i <= x2 ; i++)
            {
                for (int o = y;o <=  y2; o++)
                {
                    position = new Worldposition(i, o);
                    listtetragon.Add(new Tetragon(position));
                }
            }
        }
        public void create_wall(int x, int y, int x2, int y2)
        {
          //  listtetragon.Add(new Tetragon(position = new MyMath.Worldposition (x,y)));
         //   listtetragon.Add(new Tetragon(position = new MyMath.Worldposition(x2,y2)));
            listwall.Add(new Wall(new Tetragon(position = new Worldposition(x, y)), new Tetragon(position = new Worldposition(x2, y2))));           
        }

        //lower left and upper right Tetragons of wall
        public void create_long_wall(int x, int y, int x2, int y2)
        {

            if(Math.Abs(y - y2) + 1 == 2) {
                for (int i = x; i <= x2; i++)
                {
                   
                        listwall.Add(new Wall(new Tetragon(position = new Worldposition(i, y)), new Tetragon(position = new Worldposition(i, y+1))));
                    
                }
            }
            else {
                for (int o = y; o <= y2; o++)
                {
                    
                    
                       
                        listwall.Add(new Wall(new Tetragon(position = new Worldposition(x, o)), new Tetragon(position = new Worldposition(x+1, o))));

                    
                }
            }



        }
        public void create_room()
        { }
        public void record()
        {


            
            
                using (StreamWriter sw = File.CreateText(path + ".txt"))
                {
                   
                    for (int i = 0; i < listtetragon.Count; i++)
                    {
                        sw.WriteLine(listtetragon[i].getx());
                        // sw.Write(',');
                        sw.WriteLine(listtetragon[i].gety());
                        // sw.WriteLine();                    
                    }
                   

                }

            using (StreamWriter sw = File.CreateText(path + "wall" + ".txt"))
            {
                
                for (int i = 0; i < listwall.Count; i++)
                {
                    sw.WriteLine(listwall[i].tetragon1.getx());                    
                    sw.WriteLine(listwall[i].tetragon1.gety());                    
                    sw.WriteLine(listwall[i].tetragon2.getx());
                    sw.WriteLine(listwall[i].tetragon2.gety());



                }
            }
        }








    }
}
