using EPC.Model.Models.BuildingElementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EPC.Model.Models.StoreysModel
{
    public class StoreysInformations
    {
        public double StoreysHeightAverage { get; set; }

        public BasementDetails? Basement { get; set; }

        public RoofDetails RoofDetails { get; set; }
    }

    public class BasementDetails
    {
        public BasementHeating Heating { get; set; }
        public double BasementArea { get; set; }
        public double BasementHeight { get; set; }
        public BasementDetails()
        {
            BasementHeight = 2.4;
        }

    }
    public class BasementHeating
    {
        public double WindowArea { get; set; }
        public BasementCeilingInsulation? BasementCeilingInsulation { get; set; }

    }



    public class RoofDetails
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RoofShapeEnum RoofShape { get; set; }

        public Pitchedroof? Pitchedroof { get; set; }
        public RoofRenovation RoofRenovation { get; set; }


    }
    public class RoofRenovation
    {
        public RoofInsulation RoofInsulation { get; set; }
        public CeilingInsulation CeilingInsulation { get; set; }
    }

    public class RoofInsulation
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RoofInsulationLocationEnum InsulationLocation { get; set; }
        public Insulation InsulationDetails { get; set; }
    }
    public class CeilingInsulation
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CeilingInsulationLocation InsulationLocation { get; set; }
        public Insulation InsulationDetails { get; set; }
    }
    public class Pitchedroof
    {
        public RoofHeating? RoofHeating { get; }
        public double? RoofPitch { get; set; }

    }
    public class RoofHeating
    {

        public bool IsHeated { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Insulationstatus RoofInsulationStatus { get; set; }
        public double RoofWindowArea { get; set; }
    }
    public class Insulation
    {

        public int InsulationMesureDate { get; set; }
    }
    public enum RoofInsulationLocationEnum
    {
        BetweenRafterInsulation,
        AboveRafterInsulation,
        Both
    }
    public enum CeilingInsulationLocation
    {
        onTopStoreyCieling,
        InWallCavities_,
        Both
    }
    public enum Insulationstatus
    {
        Insulted,
        Uninsulted
    }
    public enum RoofShapeEnum
    {
        IsFlatt,
        IsPitched
    }
}
