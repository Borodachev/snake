using System.Collections.Generic;

namespace Snake
{
    class HorizontalLine:Figure
    {        
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pLine=new List<Point>();
            
            for(int i=xLeft; i<=xRight; i++)
            {
                Point p=new Point(i, y, sym);
                pLine.Add(p);
            }
        }
    }
}