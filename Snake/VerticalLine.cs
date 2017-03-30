using System.Collections.Generic;

namespace Snake
{
    class VerticalLine
    {
        List<Point> vLine;
        
        public VerticalLine(int yHome, int yEnd, int x, char sym)
        {
            vLine=new List<Point>();
            
            for(int i=yHome; i<=yEnd; i++)
            {
                Point p=new Point(x, i, sym);
                vLine.Add(p);
            }
        }
        
        public void Drow()
        {
            foreach(Point p in vLine)
            {
                p.Draw();
            }
        }
    }
}