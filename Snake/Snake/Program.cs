using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!;");
            int x = 1;
            int y = 3;
            char sym1 = '*';

            Console.SetCursorPosition(x,y);
            Console.Write(sym1);

            int x2 = 9;
            int y2 = 4;
            char sym2 = '#';

            Console.SetCursorPosition(x2, y2);
            Console.Write(sym2);



            Console.ReadKey();
        }
    }
}
