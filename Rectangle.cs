using System;

namespace Exercises.Polymorphism
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }
}
