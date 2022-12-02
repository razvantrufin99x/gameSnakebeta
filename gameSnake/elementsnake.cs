using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace gameSnake
{
    public class elementsnake
    {
        public int X;
        public int Y;
        public int Z;
        public Color culoare = Color.Green;
        public elementsnake(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public elementsnake() { }
    }
}
