using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core
{
    public class ShapeAreaService
    {
        private readonly IShapeWithArea Shape;

        public ShapeAreaService(IShapeWithArea shape)
        {
            if (shape == null)
            {
                throw new ArgumentNullException(nameof(shape));
            }

            Shape = shape;
        }

        public double GetArea() => Shape.Area;
    }
}
