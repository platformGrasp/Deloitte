using System.Drawing;
using Model.Interface;
using Model.Shapes;

namespace Model.Decorators
{
    public abstract class ShapeDecorator : IShape
    {
        protected Shape Shape;

        public ShapeDecorator(Shape shape)
        {
            Shape = shape;
        }

        public abstract int Draw();
        public void SetColor(Color color)
        {
            Shape.SetColor(color);
        }
    }
}
