using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1=new Point(1, 3, '*');            
            p1.Draw();
                        
            Point p2=new Point(4, 5, '#');
            p2.Draw();
            
            HorizontalLine pLine=new HorizontalLine(7, 14, 9, '+');
            pLine.Drow();
            
            VerticalLine vLine=new VerticalLine(7, 14, 9, '+');
            vLine.Drow();
            
            Console.ReadLine();
        }
    }
}