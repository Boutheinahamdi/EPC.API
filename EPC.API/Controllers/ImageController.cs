using EPC.API.Repository;
using EPC.Model.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EPC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IImageRepository _context;

        public ImageController(IImageRepository context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("ByID")]

        public async Task<ActionResult<ImageDTO>> GetImageByIDs(string TransactionID, string ImageID)

        {
            var image = await _context.GetImageByIDs(TransactionID, ImageID);
            return Ok(image);
        }
        [HttpPost]
        public async Task<ActionResult<ImageDTO>> AddImage([FromForm] ImageDTO imagemodel)
        {
            await _context.AddImage(imagemodel);

            return Ok();
        }
        [HttpDelete]

        public async Task<ActionResult<ImageDTO>> DeleteImage(string TransactionID, string imageID)
        {
            await _context.DeleteImage(TransactionID, imageID);

            return Ok();
        }
    }
}
