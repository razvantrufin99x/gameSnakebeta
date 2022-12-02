using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gameSnake
{
    public class sarpe
    {
        public int X;
        public int Y;
        public int Z;
        public List<elementsnake>  elementelesarpelui = new List<elementsnake>();
        public sarpe() { }
        public sarpe(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
