using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EPC.Model.Models.BuildingInformationModel
{
    public class BuildingInformation
    {
        public string TransactionID { get; set; }
        public int ConstructionYear { get; set; }
        public int ResidentailUnits { get; set; }
        public double LivingSpace { get; set; }
        public List<ExteriorWall> ExteriorWalInformations { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AttachemenTypeEnum WallAttachementType { get; set; }
        public double FootPrintArea { get; set; }
        public double FootPrintAreaPerimeter { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BuildingTypeEnum BuildingType { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ConstructionMethodEnum ConstructionMethod { get; set; }
        public int StoreysNumber { get; set; }


    }
    public class ExteriorWall
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OrientationEnum WallOrientation { get; set; }
        public double WallArea { get; set; }

    }
    public enum AttachemenTypeEnum
    {
        Detached,
        AttachedOneSide,
        AttachedBothSides
    }
    public enum BuildingTypeEnum
    {
        Single_family_house,
        Duplex_house,
        Multi_family_house,
        Other_residential_building
    }

    public enum ConstructionMethodEnum
    {
        Solid_construction,
        Wooden_construction
    }
    public enum OrientationEnum
    {
        South,
        West,
        East,
        North
    }
}
