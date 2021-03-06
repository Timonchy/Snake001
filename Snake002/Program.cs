﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Snake002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontallLine upLine = new HorizontallLine(0,78,0,'+');
            HorizontallLine downLine = new HorizontallLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0,24,0,'+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGTH);
            snake.Draw();

            Console.ReadLine();
        }
    }
}
