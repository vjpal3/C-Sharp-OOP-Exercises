using System.Collections.Generic;

namespace Exercises.Polymorphism
{
    class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                // Polymorphism at work #2: the virtual method Draw is
                // invoked on each of the derived classes, not the base class.
                shape.Draw();
            }
        }
    }
}
