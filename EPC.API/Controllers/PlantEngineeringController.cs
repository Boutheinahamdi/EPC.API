using EPC.API.Repository;
using EPC.Model.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EPC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantEngineeringController : Controller
    {
        private readonly IGenericRepository<PlantEngineeringDTO> _context;

        public PlantEngineeringController(IGenericRepository<PlantEngineeringDTO> context)
        {
            _context = context;
        }

        [HttpGet]

        [Route("ByTransactionID")]

        public async Task<ActionResult<PlantEngineeringDTO>> GetPlantEngineeringByTransactionID(string TransactionID)

        {
            var building = await _context.GetBuildingDataByTransactionID(TransactionID);
            return Ok(building);
        }
        [HttpPost]
       

        public async Task<ActionResult<PlantEngineeringDTO>> AddPlantEngineeringData(PlantEngineeringDTO plantEngineering)
        {
            await _context.AddBuildingData(plantEngineering);

            return Ok();
        }
        [HttpPut]
        

        public async Task<ActionResult<PlantEngineeringDTO>> EditPlantEngineeringData(PlantEngineeringDTO plantEngineering)
        {
            await _context.EditBuildingData(plantEngineering);

            return Ok();
        }

    }
}
