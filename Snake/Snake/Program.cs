using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           //Console.SetBufferSize( 110, 350 );
           Point p1 = new Point(1,2, '*');
          //  p1.Draw();
            Point p2 = new Point(9,15, '#');
            //  p2.Draw();


           // VerticalLine vLine = new VerticalLine(5, 1, 7, '@');
            //vLine.Draw();
            HorizontalLine hLine1 = new HorizontalLine(0,78,0,'+');
            HorizontalLine hLine2 = new HorizontalLine(0, 78, 24, '+');
            hLine1.Draw();
            hLine2.Draw();
            VerticalLine vLine1 = new VerticalLine(0,0,24, '+');
            VerticalLine vLine2 = new VerticalLine(78, 0, 24, '+');
            vLine1.Draw();
            vLine2.Draw();



            Console.ReadKey();
        }
       
    }
}
