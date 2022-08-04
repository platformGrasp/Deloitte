using System.Drawing;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IImageService
    {
        Task<bool> AddLine(string color);
        Task<bool> AddCircle(string color);
        Task<bool> AddShape(string shape, string color);
        void Paint();
    }
}