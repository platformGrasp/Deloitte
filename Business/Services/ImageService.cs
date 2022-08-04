using System;
using System.Drawing;
using System.Threading.Tasks;
using Business.Interfaces;
using Model;

namespace Business.Services
{
    public class ImageService : IImageService
    {
        private readonly Canvas _canvas;

        public ImageService()
        {
            _canvas = new Canvas();
        }

        public async Task<bool> AddLine(string color)
        {
            switch (color)
            {
                case "GREEN":
                    _canvas.AddGreenLine();
                    break;
                default:
                    return await Task.FromResult(false);
            }

            return await Task.FromResult(true); 
        }

        public async Task<bool> AddCircle(string color)
        {
            switch (color)
            {
                case "RED":
                    _canvas.AddRedCircle();
                    break;
                default:
                    return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> AddShape(string shape, string color)
        {

            try
            {
                _canvas.AddShape(shape, Color.FromName(color));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return true;
        }

        public void Paint()
        {
            _canvas.Paint();
        }
    }
}
