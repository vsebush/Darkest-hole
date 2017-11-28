using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        //this demo calculates the visibility of the hero by the guard
        static void Main(string[] args)
        {
           const int maxX = 100;
           const int maxY = 100;            
            int[,] nums = new int[maxX,maxY];
            Guard gu = new Guard(50, 50,360,180,50);
          //  Hero he = new Hero(97,97,1);
            // Console.WriteLine("Guard");
            // Console.WriteLine(" Х позиция: " + gu.xposition + " Y позиция: " + gu.yposition);
            // Console.WriteLine("Направление вектора зрения:   " + gu.vectorvision + " Угл зрения: " + gu.anglevision + " Дистанция зрения: " + gu.distancevision);
           //  Console.WriteLine("Hero");
           //  Console.WriteLine(" Х позиция: " + he.xposition + " Y позиция: " + he.yposition);
           //  Console.WriteLine(" Дистанция зрения: " + he.distancevision);


            // Console.WriteLine (MyMath.chek(he.xposition, he.yposition, gu.xposition, gu.yposition, gu.vectorvision, gu.anglevision, gu.distancevision));


            for (int i = 0; i < maxX; i++)
            {
                for (int o = 0; o < maxY; o++)
                {
                    Hero he = new Hero(i, o, 2);
                    try
                    {
                        if (false == MyMath.chek(he.xposition, he.yposition, gu.xposition, gu.yposition, gu.vectorvision, gu.anglevision, gu.distancevision))
                            Console.WriteLine(" Х позиция: " + he.xposition + " Y позиция: " + he.yposition);
                        else
                        { }
                    }

                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Division of {0} by zero.");
                    }
                }
            }
            

           














                    Console.ReadLine();
        }
    }
}
