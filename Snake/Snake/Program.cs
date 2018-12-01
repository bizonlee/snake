using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

           Point p1 = new Point(1,2, '*');
          //  p1.Draw();
            Point p2 = new Point(9,15, '#');
          //  p2.Draw();
            

            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);

            pointList[1].Draw();
            foreach (Point i in pointList)
            {
                i.Draw();
              
            }
            Console.ReadKey();
        }
       
    }
}
