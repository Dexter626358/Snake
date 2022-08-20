using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Snake
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.Clear();
            Point p1 = new Point(1, 3, '*'); // инкапсуляция
            p1.Drow();
            
            Point p2 = new Point(4, 5, '#');
            p2.Drow();

            Point p3 = new Point(6, 8, '&'); // инкапсуляция
            p3.Drow();

            Point p4 = new Point(4, 4, '%'); // инкапсуляция
            p4.Drow();

             Point p5 = new Point(3, 7, '@'); // инкапсуляция
            p5.Drow();

             Point p6 = new Point(5, 3, '$'); // инкапсуляция
            p6.Drow();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            List<Point> pointList = new List<Point>();
            pointList.Add(p3);
            pointList.Add(p4);
            pointList.Add(p5);
            pointList.Add(p6);
            


            
            
            
        }
        
    }
}


