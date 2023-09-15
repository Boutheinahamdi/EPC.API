using EPC.Model.Models.BuildingElementModel;
using EPC.Model.Models.StoreysModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPC.Model.DTOs
{
    public class StoreysDTO
    {
        public double StoreysHeightAverage { get; set; }

        public BasementDetails? Basement { get; set; }
        public BasementCeilingInsulation? BasementCeilingInsulation { get; set; }

        public RoofDetails RoofDetails { get; set; }
    }
}
