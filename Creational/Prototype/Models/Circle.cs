using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : Shape
    {
        public Circle(int x, int y, Border border) : base(x, y, border) { }

        public override Shape Clone()
        {
            return (Circle)this.MemberwiseClone();
        }

        public override void Render()
        {
            Console.WriteLine("Rendering circle");
        }
    }
}
