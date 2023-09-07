using EPC.API.Repository;
using EPC.Model.DTOs;
using EPC.Model.Models.BuildingInformationModel;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EPC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingInformationController : Controller
    {
        private readonly IGenericRepository<BuildingInformationDTO> _context;

        public BuildingInformationController(IGenericRepository<BuildingInformationDTO> context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BuildingInformationDTO>>> GetBuildingInformationByTransactionID(string TransactionID)

        {
            var building = await _context.GetBuildingInformationByTransactionID( TransactionID);
            return Ok(building);
        }
        [HttpPost]
        public async Task<ActionResult<BuildingInformationDTO>> AddBuildingInformation(BuildingInformationDTO buildingInformation)
        {
            await _context.AddBuildingInformation(buildingInformation);

            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult<BuildingInformationDTO>> EditBuildingInformation(BuildingInformationDTO buildingInformation)
        {
            await _context.EditBuildingInformation(buildingInformation);

            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult<BuildingInformationDTO>> DeleteBuildingInformation(string TransactionID)
        {
            await _context.DeleteBuildingInformation(TransactionID);

            return Ok();
        }

    }
}
