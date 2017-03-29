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
            
            List<int> numList=new List<int>();
            
            numList.Add(20);
            numList.Add(15);
            numList.Add(0);
                        
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }
                        
            Console.ReadLine();
        }
    }
}