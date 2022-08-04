using System.Drawing;
using Model.Interface;

namespace Model.Shapes
{
    public abstract class Shape: IShape
    {
        protected Point Position;
        protected Color Color;
        public abstract int Draw();

        public void SetColor(Color color)
        {
            Color = color;
        }
    }
}
