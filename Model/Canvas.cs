using System;
using System.Drawing;
using System.Threading.Tasks;
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

        public void AddShape(string shape, Color color)
        {
            switch (shape.ToLower())
            {
                case "line":
                    _diagram.AddShape(new CompositShapeDecorator(new Line(), color));
                    break;
                case "circle":
                    _diagram.AddShape(new CompositShapeDecorator(new Circle(), color));
                    break;
                case "rectangle":
                    _diagram.AddShape(new CompositShapeDecorator(new Shapes.Rectangle(), color));
                    break;
                default:
                   throw new Exception("Invalid shape");
            }
        }

        public void Paint()
        {
            _diagram.DrawAll();
        }
    }
}
