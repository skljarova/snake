﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class Snake : FR
    {
        public Snake(Point tail, int length, Direction direction)
            
    {
        plist = new List<Point>();
        for (int i = 0; i < length; i++)
           
        {
            Point p = new Point(tail);
            p.Move(i, direction);
            plist.Add(p);
        
        }
    }
    }
}
