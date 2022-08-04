using System;
using System.Diagnostics;

namespace Model.Shapes
{
    public class Circle : Shape
    {
        public override int Draw()
        {
            Debug.WriteLine("Drawing Circle");
            System.Console.WriteLine("Drawing Circle");
            return 1;
        }
    }
}
