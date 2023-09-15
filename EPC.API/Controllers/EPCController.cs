using EPC.API.Repository;
using EPC.Model.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EPC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EPCController : Controller
    {
        private readonly IEPCManagementRepository _context;

        public EPCController(IEPCManagementRepository context)
        {
            _context = context;
        }
        [HttpDelete]
        [Route("TransactionInformation")]


        public async Task<ActionResult<BuildingElementDTO>> DeleteEPCInformation(string TransactionID)
        {
            await _context.DeleteBuildingData(TransactionID);

            return Ok();
        }

        [HttpPut]
        [Route("StartProcessing")]

        public async Task<ActionResult<BuildingElementDTO>> EPCCreationStart(string TransactionID)
        {
            await _context.EPCCreationStart(TransactionID);

            return Ok();
        }

    }
}
