using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class MyMath
    {
        
        static public Boolean chek (int _hex,int _hey, int _gux, int _guy, double _vectorvision, int _angelvision, int _distancevision)
        {
            int point2x = _hex; //4
            int point2y = _hey;// 4
            int point1x = _gux;//4
            int point1y = _guy; // 7
            double vectorvision = _vectorvision;//0
            int angelvision = _angelvision;//30
            int lineR = _distancevision;//4
            int point3x;
            int point3y;
            int linea;
            int lineb;
            double angle;

            point3x = point1x + Convert.ToInt32(Math.Sin(vectorvision * Math.PI / 180))* lineR;
            point3y = point1y + Convert.ToInt32(Math.Cos(vectorvision * Math.PI / 180)) * lineR;

            linea = Convert.ToInt32(Math.Sqrt(Math.Pow(point1x-point2x,2)+ Math.Pow(point1y - point2y, 2)));
            lineb = Convert.ToInt32(Math.Sqrt(Math.Pow(point2x - point3x, 2) + Math.Pow(point2y - point3y, 2)));

            angle = Math.Acos((linea * linea + lineR * lineR - lineb * lineb)/(2*lineR*linea));
            angle = angle * 180 / Math.PI;


            if (angle > vectorvision)
                return false;
            else
                return true;

            
        }





    }
}
