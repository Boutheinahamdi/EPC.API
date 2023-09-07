using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EPC.Model.Models.BuildingElementModel
{
    public class BuildingElement
    {

        public string TransactionID { get; set; }
        public double WindowArea { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]

        public matrielEnum WindowMaterial { get; set; }
        public int WindowContructionYear { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public glazingEnum RenovatedWindows { get; set; }
        public Door? FrontDoor { get; set; }
        public ExteriorWallInsulation? ExteriorWallInsulation { get; set; }

    }

    public class Door
    {

        public double Doorarea { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]

        public DoorMaterialEnum Material { get; set; }
    }

    public enum matrielEnum
    {
        Wood,

        Aluminum,

        Plastic,

        Steel
    }
    public enum glazingEnum
    {
        DoubleGlazing,
        TripleGlazing
    }
    public enum DoorMaterialEnum
    {
        Wood,
        Plastic,
        Metal
    }
}
