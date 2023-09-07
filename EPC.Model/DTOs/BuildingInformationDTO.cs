using EPC.Model.Models.BuildingInformationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EPC.Model.DTOs
{
    public class BuildingInformationDTO
    {
        public string  TransactionID { get; set; }
        public int ConstructionYear { get; set; }
        public int ResidentailUnits { get; set; }
        public double LivingSpace { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BuildingTypeEnum BuildingType { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ConstructionMethodEnum ConstructionMethod { get; set; }
        public int StoreysNumber { get; set; }
    }
}
