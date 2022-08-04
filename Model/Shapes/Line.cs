using System;

namespace Model.Shapes
{
    public class Line: Shape
    {
        public override int Draw()
        {
            System.Console.WriteLine("Drawing Line");
            return 1;
        }
    }
}
