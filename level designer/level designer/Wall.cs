using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_designer
{
    class Wall
    {
       public Tetragon tetragon1;
        public Tetragon tetragon2;

       public Wall (Tetragon tetragon1,Tetragon tetragon2)
        {
            this.tetragon1 = tetragon1;
            this.tetragon2 = tetragon2;


        }


    }
}
