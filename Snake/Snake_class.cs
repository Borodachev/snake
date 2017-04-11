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
                p.Move(i, direction);
                pLine.Add(p);
            }
        }
        
        public void Move()
        {
            Point p_z=pLine[0];
            pLine.Remove(p_z);
            Point p_new=GetNextPoint();
            pLine.Add(p_new);
            
            p_z.Clear();
            p_new.Draw();
        }
        
        public Point GetNextPoint()
        {
            //Point p_x=pLine[pLine.Count-1];
            Point p_x=new Point(pLine[pLine.Count-1]);
            p_x.Move(1, direction);
            return p_x;
        }
        
        public void HandleKey(ConsoleKey key)
        {
            if(key==ConsoleKey.LeftArrow)
                    {
                        direction=Direction.LEFT;
                    }
                    else if(key==ConsoleKey.RightArrow)
                    {
                        direction=Direction.RIGHT;
                    }
                    else if(key==ConsoleKey.DownArrow)
                    {
                        direction=Direction.DOWN;
                    }
                    else if(key==ConsoleKey.UpArrow)
                    {
                        direction=Direction.UP;
                    }
        }
    }
}