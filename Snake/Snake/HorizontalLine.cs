﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pointList;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pointList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
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
