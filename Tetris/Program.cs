using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Point p1 = new Point(2, 3, 'c');
            p1.Draw();
            Point[] points = new Point[3];
            points[0] = new Point(5, 5, '*');
            points[1] = new Point(4, 9, '$');
            points[2] = new Point(1, 7, '?');
            foreach(Point p in points)
            {
                p.Draw();
            }

            Console.WriteLine();

            Square square1 = new Square(10, 10, '#');
            square1.DrawSquare();

            Stick stick1 = new Stick(14, 10, '|');
            stick1.DrawStick();

            Console.ReadKey();
        }
    }
}
