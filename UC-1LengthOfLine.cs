using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionUsingOops
{
    internal class UC_1LengthOfLine
    {
        public abstract class Line
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

                Line line = new CartesianLine(x1, y1, x2, y2);
                double length = line.CalculateLength();

                Console.WriteLine($"Length of the line: {length}");
            }
        }
    }
}
