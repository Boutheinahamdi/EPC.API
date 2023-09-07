using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPC.Model.Models.BuildingElementModel
{
    

    public class InsulationBase
    {
        public int InsulationMeasureDate { get; set; }
    }

    public class ExteriorWallInsulation : InsulationBase
    {
    }

    public class BasementCeilingInsulation : InsulationBase
    {
    }
}
