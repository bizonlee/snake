using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Snake
{
    class Snake: Figure
    {
        public Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pointList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pointList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            Point head = GetNextPoint();
            pointList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            

            return nextPoint;
        }

        public void Run(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
            if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
        }
    }
}
