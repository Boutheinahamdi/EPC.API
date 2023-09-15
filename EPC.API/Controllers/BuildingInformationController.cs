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
        [Route("ByTransactionID")]


        public async Task<ActionResult<BuildingInformationDTO>> GetBuildingInformationByTransactionID(string TransactionID)

        {
            var building = await _context.GetBuildingDataByTransactionID( TransactionID);
            return Ok(building);
        }
        [HttpPost]
        

        public async Task<ActionResult<BuildingInformationDTO>> AddBuildingInformation(BuildingInformationDTO buildingInformation)
        {
            await _context.AddBuildingData(buildingInformation);

            return Ok();
        }
        [HttpPut]
        

        public async Task<ActionResult<BuildingInformationDTO>> EditBuildingInformation(BuildingInformationDTO buildingInformation)
        {
            await _context.EditBuildingData(buildingInformation);

            return Ok();
        }
       

    }
}
