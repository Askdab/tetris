using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Point
    {
        int X { get; set; }
        int Y { get; set; }
        char C;

        public Point()
        {

        }

        public Point(int x, int y, char c)
        {
            this.X = x;
            this.Y = y;
            this.C = c;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(C);
        }
    }
}
