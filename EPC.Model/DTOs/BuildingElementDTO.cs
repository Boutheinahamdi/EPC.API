

using EPC.Model.Models.BuildingElementModel;
using System.Text.Json.Serialization;

namespace EPC.Model.DTOs
{
    public class BuildingElementDTO

    {
        public string TransactionID { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public matrielEnum WindowMaterial { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public glazingEnum RenovatedWindows { get; set; }
        public int WindowContructionYear { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DoorMaterialEnum Material { get; set; }
        public ExteriorWallInsulation? ExteriorWallInsulation { get; set; }

    }
}