using System;

namespace Prototype
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, Border border) : base(x, y, border) { }

        public override Shape Clone()
        {
            var cloneBase = (Rectangle)this.MemberwiseClone();

            // Clone whole object with new subobjects
            cloneBase.Border = new Border(Border.Thickness, Border.Color);

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Rendering rectangle");
        }
    }
}
