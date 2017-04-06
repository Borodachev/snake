using System.Collections.Generic;

namespace Snake
{
    class Figure
    {
        protected List<Point> pLine;
        
        public void Drow()
        {
            foreach(Point p in pLine)
            {
                p.Draw();
            }
        }
    }
}