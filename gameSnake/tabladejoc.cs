using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace gameSnake
{
    public class tabladejoc
    {
        public static int lungime = 20;
        public static int latime = 20;
        public casuta [,] casute = new casuta[lungime, latime];
        public int X;
        public int Y;
        public int Z;
        public int distanta = 0;
        public void drawTabladejoc(ref Graphics gg)
        {
            for (int i = 0; i < lungime; i++)
            {
                for (int j = 0; j < latime; j++)
                {
                    gg.DrawRectangle(new Pen(Color.Black), distanta + i * X, distanta + j * Y, 20, 20);

                }
            }
        }
        public tabladejoc(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
