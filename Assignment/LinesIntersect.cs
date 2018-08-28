using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesIntersect
{
    class Line 
    {
        //The general equation of a line is Ax+By+C=0
        public float a, b, c;

        /* The constructor takes two points and forms the line equation
         * @param a is the first point of the line
         * @param b is the second point of the line
         */
        Line(Point a, Point b)
        {
            this.a = b.y - a.y;
            this.b = b.x - a.x;
            this.c = this.a * (a.x) + this.b * (a.y);
        }

    }

    class Point
    {
        //A point has x and y coordinates
        public float x, y;
        public Point(float x,float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class IntersectChecker
    {
        /* To check if two lines are intersecting
         * @param line1 is a line
         * @param line2 is another line
         * @reutrn is a boolean
         */
        public Boolean IsIntersecting(Line line1, Line line2)
        {
            if (!(line1.a / line2.a == line1.b / line2.b))
            {
                return true;
            }
            return false;
        }
    }

    class OverlappingChecker
    {
        /* To check if two lines are Overlapping
         * @param line1 is a line
         * @param line2 is another line
         * @reutrn is a boolean
         */
        public Boolean IsOverlapping(Line line1, Line line2)
        {
            if((line1.a / line2.a == line1.b / line2.b)&&(line1.a / line2.a == line1.c / line2.c))
            {
                return true;
            }
            return false;
        }
    }

    class ParallelChecker
    {
                /* To check if two lines are Overlapping
         * @param line1 is a line
         * @param line2 is another line
         * @reutrn is a boolean
         */
        public Boolean IsParallel(Line line1, Line line2)
        {
            if ((line1.a / line2.a == line1.b / line2.b) && (line1.a / line2.a != line1.c / line2.c))
            {
                return true;
            }
            return false;
        }
    }
}
