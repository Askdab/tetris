using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Stick
    {
        int X { get; set; }
        int Y { get; set; }
        char Sym;

        Point[] points = new Point[4];

        public Stick() { }

        public Stick(int x, int y, char sym)
        {
            this.X = x;
            this.Y = y;
            this.Sym = sym;

            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y + 1, sym);
            points[2] = new Point(x, y + 2, sym);
            points[3] = new Point(x, y + 3, sym);
        }

        public void DrawStick()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
