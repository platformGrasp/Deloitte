using System;
using System.Diagnostics;

namespace Model.Shapes
{
    public class Rectangle : Shape
    {
        public override int Draw()
        {
            Debug.WriteLine("Drawing Rectangle");
            System.Console.WriteLine("Drawing Rectangle");
            return 1;
        }
    }
}
