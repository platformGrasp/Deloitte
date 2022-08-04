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
            setColor();
            return Shape.Draw();
        }

        private void setColor()
        {
            System.Console.WriteLine("Circle Color: Red");
            Shape.SetColor(Color.Red);
        }
    }
}
