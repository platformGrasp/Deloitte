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
            setColor();
            return Shape.Draw();
        }

        private void setColor()
        {
            System.Console.WriteLine("Rectangle Color: Black");
            Shape.SetColor(Color.Black);
        }
    }
}
