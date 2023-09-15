using EPC.API.Repository;
using EPC.Model.DTOs;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

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
        [Route("ByTransactionID")]

        [ProducesResponseType(typeof(BuildingElementDTO), (int)HttpStatusCode.OK)]

        public async Task<ActionResult<IEnumerable<BuildingElementDTO>>> GetBuildingElementByTransactionID(string TransactionID)

        {
            var building = await _context.GetBuildingDataByTransactionID(TransactionID);
            return Ok(building);
        }
        [HttpPost]
        

        public async Task<ActionResult<BuildingElementDTO>> AddBuildingElements(BuildingElementDTO buildingInformation)
        {
            await _context.AddBuildingData(buildingInformation);

            return Ok();
        }
        [HttpPut]
       

        public async Task<ActionResult<BuildingElementDTO>> EditBuildingElements(BuildingElementDTO buildingInformation)
        {
            await _context.EditBuildingData(buildingInformation);

            return Ok();
        }
       
    }
}
