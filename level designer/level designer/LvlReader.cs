using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace level_designer
{
    class LvlReader 
    {
       
        
        public string path;
        public List<Wall> listwall = new List<Wall>();
        public List<Tetragon> listtetragon = new List<Tetragon>();
        public List<Hero> listheroes = new List<Hero>();



        public LvlReader(string path)
        {
           this.path = path;
        }


       public void start()
        {

            ///////////////////////////////////////////TETRAGON//////////////////////////////////////////////////////////////////////////
            using (StreamReader sr = new StreamReader(path + ".txt", System.Text.Encoding.Default))
            {
                string line;
                int i = 0;
                bool flag = false;
                Worldposition position = new Worldposition(0, 0);
                while ((line = sr.ReadLine()) != null)
                {
                    if (flag == false)
                    {
                        listtetragon.Add(new Tetragon(position));
                        listtetragon[i].setx(Convert.ToInt32(line));
                        flag = true;
                        
                    }
                    else
                    {
                        listtetragon[i].sety(Convert.ToInt32(line));
                        flag = false;
                        i++;
                    }                    

                }

            }
            /////////////////////////////////////////////WALLL/////////////////////////////////////////////////////
            using (StreamReader sr = new StreamReader(path + "wall" + ".txt", System.Text.Encoding.Default))
            {
                string line;
                int i = 0;
                int flag = 0;
                Worldposition position = new Worldposition(0, 0);
                while ((line = sr.ReadLine()) != null)
                {
                    switch (flag)
                    {

                        case 0:
                            listwall.Add(new Wall(new Tetragon(position = new Worldposition(0, 0)), new Tetragon(position = new Worldposition(0, 0))));
                            listwall[i].tetragon1.setx(Convert.ToInt32(line));
                            flag++;
                            break;
                        case 1:
                            listwall[i].tetragon1.sety(Convert.ToInt32(line));
                            flag++;
                            break;
                        case 2:
                            listwall[i].tetragon2.setx(Convert.ToInt32(line));
                            flag++;
                            break;
                        case 3:
                            listwall[i].tetragon2.sety(Convert.ToInt32(line));
                            flag = 0;
                            i++;
                            break;


                    }

                }

            }
            ////////////////////////////////////////////////////HEROES//////////////////////////////////////////
            using (StreamReader sr = new StreamReader(path + "heroes" + ".txt", System.Text.Encoding.Default))
            {
                string line;
                int i = 0;
                int flag = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    switch (flag)
                    {
                        case 0:
                            listheroes.Add(new Hero());
                            listheroes[i].name = line;
                            flag++;
                            break;

                        case 1:
                            listheroes[i].hp = Convert.ToInt32(line);
                            flag++;
                            break;

                        case 2:
                            listheroes[i].ap = Convert.ToInt32(line);
                            i++;
                            flag = 0;                             
                            break;

                        









                    }




                }




















            }




        }




    }
}

