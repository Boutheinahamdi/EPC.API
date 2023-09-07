using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPC.Model.DTOs
{
    public class ImageDTO
    {
        public string TransactionID { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
