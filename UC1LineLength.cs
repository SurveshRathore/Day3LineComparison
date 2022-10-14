using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3LineComparison
{
    internal class UC1LineLength
    {
        public void calcLineLength (double x1, double y1, double x2, double y2)
        {
            double lineLength;
            lineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The length of a line is: " + lineLength);
        }
    }
}
