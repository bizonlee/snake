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


            VerticalLine vLine = new VerticalLine(5, 1, 7, '@');
            vLine.Draw();
            HorizontalLine hLine = new HorizontalLine(1,6,3,'+');
            hLine.Draw();


          
            Console.ReadKey();
        }
       
    }
}
