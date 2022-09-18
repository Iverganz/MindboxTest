using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core
{
    public class Triangle : IShapeWithArea
    {
        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        public double Area
        {
            get
            {
                var p = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideB >= sideC + sideA || sideA >= sideC + sideB || sideC >= sideA + sideB)
            {
                throw new ArgumentException("Triangle can not exist.");
            }

            SideA = sideA > 0 ? sideA : throw new ArgumentException(nameof(SideA));

            SideB = sideB > 0 ? sideB : throw new ArgumentException(nameof(sideB));

            SideC = sideC > 0 ? sideC : throw new ArgumentException(nameof(sideC));


        }

        public bool IsRight
        {
            get
            {
                var a2 = Math.Pow(SideA, 2);
                var b2 = Math.Pow(SideB, 2);
                var c2 = Math.Pow(SideC, 2);
                return a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2;
            }
        }

    }
}
