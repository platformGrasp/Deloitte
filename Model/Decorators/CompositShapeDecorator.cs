using System.Diagnostics;
using System.Drawing;
using Model.Shapes;

namespace Model.Decorators
{
    public class CompositShapeDecorator : ShapeDecorator
    {
        private readonly Color _color;

        public CompositShapeDecorator(Shape decoratedShape, Color color) : base(decoratedShape)
        {
            _color = color;
        }

        public override int Draw()
        {
            SetColor();
            return Shape.Draw();
        }

        private void SetColor()
        {
            Debug.WriteLine($"Circle Color: {_color.Name}");
            System.Console.WriteLine($"Circle Color: {_color.Name}");
            Shape.SetColor(_color);
        }
    }
}
