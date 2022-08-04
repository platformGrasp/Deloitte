using System.Drawing;

namespace Model.Interface
{
    public interface IShape
    {
        int Draw();
        void SetColor(Color color);
    }
}