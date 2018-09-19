using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

       

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine Line = new HorizontalLine(5, 10, 8, '+');
            Line.Draw();

            VerticalLine vline = new VerticalLine(5, 5, 10, '+');
            vline.Draw();


            Console.ReadLine();
        }

    }
}
