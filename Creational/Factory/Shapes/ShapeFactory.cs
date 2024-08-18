using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Shapes
{
    public class ShapeFactory
    {
        public static Shape CreateShape(string type)
        {
            return type switch
            {
                nameof(Circle) => new Circle(),
                nameof(Rectangle) => new Rectangle(),
                nameof(Triangle) => new Triangle(),
                _ => throw new Exception($"Type {type} is not implemented in ShapeFactory.CreateShape()"),
            };
        }
    }
}
