using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tetragon : worldposirtion
    {
        public int x;
        public int y;

        object entity;
        object furniture;

        public int xposition
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }

        }
        public int yposition
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }

        }      


       public Tetragon (MyMath.Worldposition position)
        {
            this.xposition = position.xposition;
            this.yposition = position.yposition;


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
