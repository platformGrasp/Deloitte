using System;

namespace Model.Shapes
{
    public class Circle : Shape
    {
        public override int Draw()
        {
            System.Console.WriteLine("Drawing Circle");
            return 1;
        }
    }
}
