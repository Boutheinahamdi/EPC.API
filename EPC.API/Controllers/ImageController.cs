using EPC.API.Repository;
using EPC.Model.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EPC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IGenericRepository<ImageDTO> _context;

        public ImageController(IGenericRepository<ImageDTO> context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImageDTO>>> GetImageByTransactionID(string TransactionID)

        {
            var image = await _context.GetBuildingInformationByTransactionID(TransactionID);
            return Ok(image);
        }
        [HttpPost]
        public async Task<ActionResult<ImageDTO>> AddBuildingInformation([FromForm] ImageDTO imagemodel)
        {
            await _context.AddBuildingInformation(imagemodel);

            return Ok();
        }
    }
}
