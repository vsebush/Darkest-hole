using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_designer
{
    class Tetragon
    {
        private Worldposition position;

        public Tetragon(Worldposition position)
        {
            this.position = position;

        }

        public Worldposition getposition()
        {
            return position;
        }

        public int getx()
        {
            return position.xposition;
        }
        public int gety()
        {
            return position.yposition;
        }
        
        public void setposition (Worldposition position)
        {
            this.position = position;
        }
        public void setx(int x)
        {
            this.position.xposition = x;
        }
        public void sety(int y)
        {
            this.position.yposition = y;
        }










    }
}
