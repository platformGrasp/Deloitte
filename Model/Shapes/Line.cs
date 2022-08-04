using System;
using System.Diagnostics;

namespace Model.Shapes
{
    public class Line: Shape
    {
        public override int Draw()
        {
            Debug.WriteLine("Drawing Line");
            System.Console.WriteLine("Drawing Line");
            return 1;
        }
    }
}
