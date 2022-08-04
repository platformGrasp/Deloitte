using System.Collections.Generic;
using Model.Interface;

namespace Model
{
    public class Diagram
    {
        private readonly List<IShape> _shapes;

        public Diagram()
        {
            _shapes = new List<IShape>();
        }

        public void DrawAll()
        {
            foreach (var item in _shapes)
            {
                item.Draw();
            }
        }

        public void AddShape(IShape item)
        {
            _shapes.Add(item);
        }

        public void DeleteShape(IShape item)
        {
            _shapes.Remove(item);
        }

        public int ShapeCount()
        {
            return _shapes.Count;
        }
    }
}
