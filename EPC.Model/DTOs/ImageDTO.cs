using Microsoft.AspNetCore.Http;
using EPC.Model.Models.ImagesModel;
using System.ComponentModel.DataAnnotations;

namespace EPC.Model.DTOs
{
    public class ImageDTO
    {
        public string TransactionID { get; set; }
        public string ImageID { get; set; }
        public string Description { get; set; }
        public type ImageType { get; set; }

        public IFormFile Image { get; set; }
    }
}
