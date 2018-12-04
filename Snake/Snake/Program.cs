using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           //Console.SetBufferSize( 110, 350 );
           
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

            Point p = new Point(7, 8, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            for (int i = 1; i <= 23; i++)
            {
                snake.Move();
                Thread.Sleep(300);
                
            }


            Console.ReadKey();
        }
       
    }
}
