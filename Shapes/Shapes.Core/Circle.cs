using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core
{
    public class Circle : IShapeWithArea
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Math.Pow(Radius, 2);

        public Circle(double radius)
        {
            Radius = radius > 0? radius: throw new ArgumentException(nameof(radius));
        }
    }
}
