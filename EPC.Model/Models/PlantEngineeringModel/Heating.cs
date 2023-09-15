using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EPC.Model.Models.PlantEngineeringModel
{
    public class Heating
    {
        public HeatingSystem HeatingSystem { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DistributionTypes HeatingType { get; set; }
        public int HeatingYearOfConstruction { get; set; }
        public bool NightShutDown { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public HeatingPump HeatingPump { get; set; }
        public RadiatorType RadiatorType { get; set; }
        public HotWaterGenerationDistribution HotWaterGenerationDistribution { get; set; }
        public Ventilation Ventilation { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Cooling Cooling { get; set; }
    }
    public enum DistributionTypes
    {
        Central,
        Decentral
    }
    public enum HeatingPump
    {
        Controlled,
        Uncontrolled
    }
    public enum RadiatorType
    {

        Radiators, Underfloor_heating, Ceiling_heating


    }
    public class Surfaceheating
    {
        public bool UnderfloorHeating { get; set; }
        public bool CeilingHeating { get; set; }
    }
    public class HotWaterGenerationDistribution
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DistributionTypes HotWaterDistributionType { get; set; }
        public int YearOfConstruction { get; set; }
    }
    public class Ventilation
    {

        public Central? Central { get; set; }

        public Decentralized? Decentral { get; set; }

        public HeatRecovery HeatRecovery { get; set; }
    }
    public class Central
    {

        public bool? IsConnectedToHeatGenerator { get; set; }
    }
    public class Decentralized
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VentilationScheme? VentilationScheme { get; set; }
    }
    public enum VentilationScheme
    {
        Apartment_wise,
        Room_wise
    }
}
