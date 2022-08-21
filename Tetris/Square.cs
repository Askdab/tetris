using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Square
    {
        int X { get; set; }
        int Y { get; set; }
        char Sym;

        Point[] points = new Point[4];

        public Square() { }

        public Square(int x, int y, char sym)
        {
            this.X = x;
            this.Y = y;
            this.Sym = sym;

            points[0] = new Point(x, y, sym);
            points[1] = new Point(x + 1, y, sym);
            points[2] = new Point(x, y + 1, sym);
            points[3] = new Point(x + 1, y + 1, sym);
        }

        public void DrawSquare()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
