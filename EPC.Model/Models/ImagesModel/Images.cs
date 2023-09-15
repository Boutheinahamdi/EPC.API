using Microsoft.AspNetCore.Http;


namespace EPC.Model.Models.ImagesModel
{
    internal class Images
    {
        public string TransactionID { get; set; }
        public string ImageID { get; set; }
        public string Description { get; set; }
        public type ImageType { get; set; }
        public IFormFile Image { get; set; }
    }
    public enum type { }
}
