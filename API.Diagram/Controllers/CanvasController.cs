using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Threading.Tasks;
using API.Diagram.Dto;
using Business.Interfaces;

namespace API.Diagram.Controllers
{
    [ApiController]
    [Route("api/canvas")]
    public class CanvasController : ControllerBase
    {
       
        private readonly ILogger<CanvasController> _logger;
        private readonly IImageService _imageService;

        public CanvasController(ILogger<CanvasController> logger, IImageService imageService)
        {
            _logger = logger;
            _imageService = imageService;
        }
        
        [HttpPost()]
        [Route("shape/line/color/green")]
        public async Task<ActionResult<ServiceResult<bool>>> AddLine()
        {
            var result = await _imageService.AddLine("GREEN");
            var response = new ServiceResult<bool>
            {
                Result = result,
                HttpStatusCode = result ? HttpStatusCode.OK : HttpStatusCode.NotFound,
                Message = new Message
                {
                    Code = result ? HttpStatusCode.OK.ToString() : HttpStatusCode.NotFound.ToString()
                }
            };

            return await Task.FromResult(response);
        }

        [HttpPost()]
        [Route("shape/circle/color/red")]
        public async Task<ActionResult<ServiceResult<bool>>> AddCircle()
        {
            var result = await _imageService.AddCircle("RED");
            var response = new ServiceResult<bool>
            {
                Result = result,
                HttpStatusCode = result ? HttpStatusCode.OK : HttpStatusCode.NotFound,
                Message = new Message
                {
                    Code = result ? HttpStatusCode.OK.ToString() : HttpStatusCode.NotFound.ToString()
                }
            };

            return await Task.FromResult(response);
        }


        [HttpGet()]
        [Route("paint")]
        public async Task<ActionResult<ServiceResult<bool>>> Paint()
        {
            _imageService.Paint();
            var response = new ServiceResult<bool>
            {
                HttpStatusCode = HttpStatusCode.OK,
                Message = new Message
                {
                    Code = HttpStatusCode.OK.ToString()
                }
            };

            return await Task.FromResult(response);
        }
    }
}
