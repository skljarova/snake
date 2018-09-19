using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class Program
    {
        static void Main(string[] args)
        {
            HLine UL = new HLine(0, 78, 0, '+');
            HLine DL = new HLine(0, 78, 24, '+');
            VLine LL = new VLine(0, 24, 0, '+');
            VLine RL = new VLine(0, 24, 78, '+');

            UL.Drow();
            DL.Drow();
            LL.Drow();
            RL.Drow();


            Point p = new Point(4, 5, '*');
            p.Draw();

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();  
             Console.ReadLine();

        }




    }
}