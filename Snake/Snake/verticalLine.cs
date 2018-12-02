using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    

    class verticalLine
    {
        List<Point> pointList;

        public verticalLine(int x, int yTop, int yBottom,  char sym)
        {
            pointList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pointList.Add(p);
            }
            
        }

        public void Draw()
        {
            foreach (Point p in pointList)
            {
                p.Draw();
            }
        }
    }
}
