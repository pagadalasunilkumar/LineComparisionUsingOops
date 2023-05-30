using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionUsingOops
{
    internal class UC_3Compare
    {
        public abstract class Line : IComparable<Line>
        {
            protected int x1, y1, x2, y2;

            public Line(int x1, int y1, int x2, int y2)
            {
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
            }

            public abstract double CalculateLength();

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

        public class CartesianLine : Line
        {
            public CartesianLine(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
            {
            }

            public override double CalculateLength()
            {
                double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                return length;
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                int x1 = 0, y1 = 0;
                int x2 = 3, y2 = 4;

                Line line1 = new CartesianLine(x1, y1, x2, y2);
                Line line2 = new CartesianLine(x1, y1, x2, y2);

                double length1 = line1.CalculateLength();
                double length2 = line2.CalculateLength();

                Console.WriteLine("Length of line 1: " + length1);
                Console.WriteLine("Length of line 2: " + length2);

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
