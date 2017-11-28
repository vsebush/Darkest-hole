using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Guard : Entity
    {



        public Guard(int x, int y, double vectorvision, int anglevision, int distancevision)
        {
            this.x = x;
            this.y = y;
            _vectorvision = vectorvision;
            _anglevision = anglevision;
            _distancevision = distancevision;
        }


    }
}
