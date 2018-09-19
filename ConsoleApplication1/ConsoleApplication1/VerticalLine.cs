using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class VLine : FR
    {


        public VLine(int yu, int yd, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yu; y <= yd; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }



    }
}