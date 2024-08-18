using System;

namespace Prototype
{
    class Program
    {
        // Prototype allows to copy existing objects without creating dependencies.

        static void Main(string[] args)
        {
            // Shallow clone:
            var circle = new Circle(1, 2, new(1, "black"));
            var copiedCircle = (Circle)circle.Clone();

            // A new object has been created
            bool areEqual = ReferenceEquals(circle, copiedCircle); // false

            // The reference inside is the same
            bool arebordersEqual = ReferenceEquals(circle.Border, copiedCircle.Border); // true

            // Common object
            circle.Border.Color = "red";
            string borderColor = copiedCircle.Border.Color;


            // Klonowanie głębokie:
            var rectangle = new Rectangle(3, 4, new Border(0, "blue"));
            var copiedRectangle = rectangle.Clone();
            copiedRectangle.Border.Color = "green";
        }
    }
}
