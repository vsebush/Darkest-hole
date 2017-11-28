using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tetragon
    {
        int x;
        int y;
        object entity;
        object furniture;



        public Tetragon(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        void haveentity (object entity)
        {
            this.entity = entity;
        }

        void havefurniture(object furniture)
        {
            this.furniture = furniture;
        }





    }
}
