using System.Diagnostics;
using System.Drawing;
using Model.Shapes;

namespace Model.Decorators
{
    public class GreenLineDecorator : ShapeDecorator
    {
        public GreenLineDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public override int Draw()
        {
            SetColor();
            return Shape.Draw();
        }

        private void SetColor()
        {
            Debug.WriteLine("Line Color: Green");
            System.Console.WriteLine("Line Color: Green");
            Shape.SetColor(Color.Green);
        }
    }
}
