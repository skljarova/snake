﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class FC
    {
        
		int mapWidht;
		int mapHeight;
		char sym;

		Random random = new Random( );

		public FC(int mapWidth, int mapHeight, char sym)
		{
			this.mapWidht = mapWidth;
			this.mapHeight = mapHeight;
			this.sym = sym;
      }

		public Point CreateFood()
		{
			int x = random.Next( 2, mapWidht - 2 );
			int y = random.Next( 2, mapHeight - 2 );
			return new Point( x, y, sym );
		}
	}
}


