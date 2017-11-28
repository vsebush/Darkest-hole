using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Entity : worldposirtion, tunnelvision , normalvision
    {
        public  int x;
        public int y;
        public int _distancevision;
        public double _vectorvision;
        public int _anglevision;
        


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
        public double vectorvision { get { return _vectorvision; } set { _vectorvision = value; } }
        public int anglevision { get { return _anglevision; } set { _anglevision = value; } }
        public int distancevision { get { return _distancevision; } set { _distancevision = value; } }




    }
}
