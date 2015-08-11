using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class TriangleAreaCalculator
    {
        public double RightTriangleAreaCalc(double side1, double side2, double side3)
        {
            IList<double> parList = new List<double>() { side1, side2, side3 };

            foreach (var side in parList)
                if (side <= 0)
                    throw new ArgumentOutOfRangeException("side" + parList.IndexOf(side)+1, "Negative or zero value");

            var hype = parList.Max();
            parList.Remove(hype);

            if (hype != Math.Sqrt(parList.Select(x => x * x).Sum()))
            {
                throw new ArgumentException("Not right triangle value");
            }
            return 0.5 * parList[0] * parList[1];

        }
    }
}
