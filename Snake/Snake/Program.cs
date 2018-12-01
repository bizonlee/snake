using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point();
            p1.x = 3;
            p1.y = 4;
            p1.sym = '*';
            p1.Draw();
            Point p2 = new Point();
            p2.x = 6;
            p2.y = 9;
            p2.sym = '#';
            p2.Draw();
            Console.ReadKey();
        }
       
    }
}
