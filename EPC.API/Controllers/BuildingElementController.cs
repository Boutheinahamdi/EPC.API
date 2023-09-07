using EPC.API.Repository;
using EPC.Model.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EPC.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BuildingElementController : Controller
    {

        private readonly IGenericRepository<BuildingElementDTO> _context;

        public BuildingElementController(IGenericRepository<BuildingElementDTO> context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BuildingElementDTO>>> GetBuildingElementByTransactionID(string TransactionID)

        {
            var building = await _context.GetBuildingInformationByTransactionID(TransactionID);
            return Ok(building);
        }
        [HttpPost]
        public async Task<ActionResult<BuildingElementDTO>> AddBuildingInformation(BuildingElementDTO buildingInformation)
        {
            await _context.AddBuildingInformation(buildingInformation);

            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult<BuildingElementDTO>> EditBuildingInformation(BuildingElementDTO buildingInformation)
        {
            await _context.EditBuildingInformation(buildingInformation);

            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult<BuildingElementDTO>> DeleteBuildingInformation(string TransactionID)
        {
            await _context.DeleteBuildingInformation(TransactionID);

            return Ok();
        }
    }
}
