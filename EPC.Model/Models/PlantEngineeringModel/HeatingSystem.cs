using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EPC.Model.Models.PlantEngineeringModel
{
    public class HeatingSystem
    {

        public Oil? Oil { get; set; }

        public Gaz? Gas { get; set; }
        public Electricity? Electricity { get; set; }
        public RenewableEnergy? RenewableEnergy { get; set; }
    }
    public class Electricity
    {
        public ElectricityDeviceType ElectricityDeviceType { get; set; }
    }
    public class RenewableEnergy
    {

        public PV? PV { get; set; }

        public SolarThermal? SolarThermal { get; set; }

        public HeatRecovery? HeatRecovery { get; set; }
        public DistrictHeating DistrictHeating { get; set; }
        public HeatPump HeatPump { get; set; }
        public Biomass Biomass { get; set; }
    }
    public class Oil
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BoilersTypes? OilBoilersType { get; set; }
    }
    public class Gaz
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BoilersTypes? GazBoilersType { get; set; }
    }
    public class PV
    {
        public string SolarOrientation { get; set; }
        public bool Battery { get; set; }
        public double KWPeak { get; set; }
        public double Area { get; set; }
    }
    public class SolarThermal
    {
        public string SolarOrientation { get; set; }
        public double SystemArea { get; set; }
        public double Buffersize { get; set; }
    }
    #region MechanicalVentilation   
    public class MechanicalVentilation
    {



        public HeatRecovery? HeatRecovery { get; set; }
        public DistrictHeating DistrictHeating { get; set; }
        public HeatPump HeatPump { get; set; }
        public Biomass Biomass { get; set; }

    }

    public class HeatRecovery
    {

        public string? HeatRecoveryEfficiency { get; set; }
    }
    #region DistrictHeating

    public class DistrictHeating
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DistrictHeatingTypes HeatingDistributionType { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EnergySource EnergySource { get; set; }
        public double BufferMemorySize { get; set; }
    }
    public enum DistrictHeatingTypes
    {
        High_pressure_steam,
        Low_pressure_steam,
        Water_high_temp,
        Water_low_temp
    }
    public enum EnergySource
    {
        Local_District_heating_from_heating_plants,
        Local_district_heating_CHP_fossil_fuel,
        Local_district_heating_CHP_renewable_fuel,
        Waste_heat_from_incineration_of_municipal_waste
    }
    #endregion
    #region HeatPump
    public class HeatPump
    {
        public double BufferStorage { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public HeatPumpTypes HeatPumpType { get; set; }
        public bool coolingFunction { get; set; }
    }
    public enum HeatPumpTypes
    {
        Air_Air,
        Ground_Water,
        Water_Water,
        Air_Water
    }
    #endregion
    #region Biomass
    public class Biomass
    {
        public double BufferSize { get; set; }
        public BiomassTypes BiomassType { get; set; }
    }
    public enum BiomassTypes
    {
        Wood_chips,
        Pellets
    }
    #endregion
    public enum Cooling
    {
        Central,
        Decentral
    }
    #endregion

    public enum BoilersTypes
    {
        Condensing_Boilers,
        Low_Temperature_Boilers

    }
    public enum ElectricityDeviceType
    {
        night_storage_heater, Direct_heating
    }
}
