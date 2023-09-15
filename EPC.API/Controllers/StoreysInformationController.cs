using EPC.API.Repository;
using EPC.Model.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EPC.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StoreysInformationController : Controller
    {
        private readonly IGenericRepository<StoreysDTO> _context;

        public StoreysInformationController(IGenericRepository<StoreysDTO> context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("ByTransactionID")]



        public async Task<ActionResult<StoreysDTO>> GetStoreysDataByTransactionID(string TransactionID)

        {
            var building = await _context.GetBuildingDataByTransactionID(TransactionID);
            return Ok(building);
        }
        [HttpPost]

        public async Task<ActionResult<StoreysDTO>> AddStoreysData(StoreysDTO storeys)
        {
            await _context.AddBuildingData(storeys);

            return Ok();
        }
        [HttpPut]

        public async Task<ActionResult<StoreysDTO>> EditStoreysData(StoreysDTO storeys)
        {
            await _context.EditBuildingData(storeys);

            return Ok();
        }
    }
}
