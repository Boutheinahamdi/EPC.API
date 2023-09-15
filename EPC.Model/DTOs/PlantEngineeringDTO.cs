using EPC.Model.Models.PlantEngineeringModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPC.Model.DTOs
{
    public class PlantEngineeringDTO
    {

        public Oil? Oil { get; set; }

        public Gaz? Gas { get; set; }
        public Electricity? Electricity { get; set; }
        public RenewableEnergy? RenewableEnergy { get; set; }
    }
}
