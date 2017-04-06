using System;
using System.Collections.Generic;
using System.Text;
//using System.Linq;

namespace Snake
{
    class Snake:Figure
    {
        Direction direction;
        
        public Snake(Point tail, int lenght, Direction direct)
        {
            direction=direct;
            pLine=new List<Point>();
            
            for(int i=0; i<lenght; i++)
            {
                Point p=new Point(tail);
                p.Move(i, direct);
                pLine.Add(p);
            }
        }
        
        public void Move()
        {
            Point p_z=pLine[0];
            pLine.Remove(p_z);
            Point p_p=GetNextPoint();
            pLine.Add(p_p);
            
            p_z.Clear();
            p_p.Draw();
        }
        
        public Point GetNextPoint()
        {
            Point p_x=pLine[pLine.Count-1];
            Point p_x1=new Point(p_x);
            p_x1.Move(1, direction);
            return p_x1;
        }
        
    }
}