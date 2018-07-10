using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace level_designer
{
    class Level 
    {   public string nameoflvl;
        public string path;              
        public List<Hero> listhero = new List<Hero>();
        public List<Guard> listguard = new List<Guard>();        
        public LvlReader read1;
        public Level(string path)
        {this.path = path;
         LvlReader read = new LvlReader(path);
         read1 = read; }
       public LvlReader le = new LvlReader(@"c:\tmp\MyTest");
        

     //   Searchway way = new Searchway(null, null,null,null);





        ////////////////////////////////////START/////////////////////////////////////////////////////////////////






















        ////////////////////////////////////UPDATE/////////////////////////////////////////////////////////////////




























    }
}
