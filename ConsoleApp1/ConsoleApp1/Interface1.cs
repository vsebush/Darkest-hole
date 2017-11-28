using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface worldposirtion
    {
        int xposition
        {
            get;
            set;
        }
        int yposition
        {
            get;
            set;
        }
        
    }
    interface tunnelvision
    {

        double vectorvision
        {
            get;
            set;
        }
        int anglevision
        {
            get;
            set;
        }

        int distancevision
        {
            get;
            set;
        }

        

}
    interface normalvision
    {
        int distancevision
        {
            get;
            set;
        }



    }
}
