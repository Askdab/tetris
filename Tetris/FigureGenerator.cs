﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class FigureGenerator
    {
        private int _x;
        private int _y;
        private char _c;

        private Random _rand = new Random();

        public FigureGenerator(int x, int y, char c)
        {
            this._x = x;
            this._y = y;
            this._c = c;
        }

        public Figure GetNewFigure()
        {
            if (_rand.Next(0, 2) == 0) return new Square(_x, _y, _c);

            else return new Stick(_x, _y, _c);
        }
    }
}
