using System.Diagnostics;
using System.Drawing;
using Model.Shapes;

namespace Model.Decorators
{
    public class BlackRectangleDecorator : ShapeDecorator
    {
        public BlackRectangleDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public override int Draw()
        {
            SetColor();
            return Shape.Draw();
        }

        private void SetColor()
        {
            Debug.WriteLine("Rectangle Color: Black");
            System.Console.WriteLine("Rectangle Color: Black");
            Shape.SetColor(Color.Black);
        }
    }
}
