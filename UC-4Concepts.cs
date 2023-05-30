using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionUsingOops
{
    internal class UC_4Concepts
    {
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override bool Equals(object obj)
            {
                if (obj is Point otherPoint)
                {
                    return X == otherPoint.X && Y == otherPoint.Y;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return X.GetHashCode() ^ Y.GetHashCode();
            }
        }

        public class Line : IComparable<Line>
        {
            public Point StartPoint { get; set; }
            public Point EndPoint { get; set; }

            public Line(Point startPoint, Point endPoint)
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
            }

            public double CalculateLength()
            {
                double length = Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) + Math.Pow(EndPoint.Y - StartPoint.Y, 2));
                return length;
            }

            public bool Equals(Line other)
            {
                return StartPoint.Equals(other.StartPoint) && EndPoint.Equals(other.EndPoint);
            }

            public int CompareTo(Line other)
            {
                double length1 = CalculateLength();
                double length2 = other.CalculateLength();

                if (length1 < length2)
                {
                    return -1;
                }
                else if (length1 > length2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Point startPoint = new Point(0, 0);
                Point endPoint = new Point(3, 4);

                Line line1 = new Line(startPoint, endPoint);
                Line line2 = new Line(startPoint, endPoint);

                double length1 = line1.CalculateLength();
                double length2 = line2.CalculateLength();

                Console.WriteLine("Length of line 1: " + length1);
                Console.WriteLine("Length of line 2: " + length2);

                bool areEqual = line1.Equals(line2);
                Console.WriteLine("Are the lines equal? " + areEqual);

                int comparisonResult = line1.CompareTo(line2);
                if (comparisonResult < 0)
                {
                    Console.WriteLine("Line 1 is less than Line 2");
                }
                else if (comparisonResult > 0)
                {
                    Console.WriteLine("Line 1 is greater than Line 2");
                }
                else
                {
                    Console.WriteLine("Line 1 is equal to Line 2");
                }
            }
        }

    }
}
