﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace змейка
{
    class FR
    {
        protected List<Point> plist;
        public void Drow()
        {
            foreach (Point p in plist)
                p.Draw();
        }
    }
}