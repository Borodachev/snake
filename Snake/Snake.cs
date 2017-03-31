using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            
            HorizontalLine pL1=new HorizontalLine(0, 78, 0, '+');
            VerticalLine vL1=new VerticalLine(0, 22, 78, '+');
            HorizontalLine pL2=new HorizontalLine(0, 78, 23, '+');
            VerticalLine vL2=new VerticalLine(0, 22, 0, '+');
            pL1.Drow();
            pL2.Drow();
            vL1.Drow();
            vL2.Drow();
            
            Point p1=new Point(1, 3, '*');            
            p1.Draw();
                        
            Console.ReadLine();
        }
    }
}