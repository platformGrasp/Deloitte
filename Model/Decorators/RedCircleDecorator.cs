using System.Diagnostics;
using System.Drawing;
using Model.Shapes;

namespace Model.Decorators
{
    public class RedCircleDecorator : ShapeDecorator
    {
        public RedCircleDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public override int Draw()
        {
            SetColor();
            return Shape.Draw();
        }

        private void SetColor()
        {
            Debug.WriteLine("Circle Color: Red");
            System.Console.WriteLine("Circle Color: Red");
            Shape.SetColor(Color.Red);
        }
    }
}
