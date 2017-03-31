using System.Collections.Generic;

namespace Snake
{
    class VerticalLine:Figure
    {        
        public VerticalLine(int yHome, int yEnd, int x, char sym)
        {
            pLine=new List<Point>();
            
            for(int i=yHome; i<=yEnd; i++)
            {
                Point p=new Point(x, i, sym);
                pLine.Add(p);
            }
        }        
    }
}