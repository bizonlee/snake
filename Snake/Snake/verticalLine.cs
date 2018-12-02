using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    

    class VerticalLine: Figure
    {
        //List<Point> pointList;

        public VerticalLine(int x, int yTop, int yBottom,  char sym)
        {
            pointList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pointList.Add(p);
            }
            
        }

       
    }
}
