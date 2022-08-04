using Model.Decorators;
using Model.Shapes;

namespace Model
{
    public class Canvas
    {
        private readonly Diagram _diagram;

        public Canvas()
        {
            _diagram = new Diagram();
        }

        public void AddRedCircle()
        {
            _diagram.AddShape(new RedCircleDecorator(new Circle()));
        }

        public void AddGreenLine()
        {
            _diagram.AddShape(new GreenLineDecorator(new Line()));
        }


        public void Paint()
        {
            _diagram.DrawAll();
        }
    }
}
