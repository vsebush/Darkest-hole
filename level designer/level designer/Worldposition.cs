using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_designer
{
    class Worldposition
    {
        public int xposition { get; set; }
        public int yposition { get; set; }

        public Worldposition(int x, int y)
        {
            xposition = x;
            yposition = y;
        }
        
    }
}
