using EPC.Model.DTOs;

namespace EPC.API.Repository
{
    public interface IImageRepository
    {
        Task<IEnumerable<ImageDTO>> GetImageByIDs(string TransactionID,string imageID);
        Task AddImage(ImageDTO image);
     
        Task<bool> DeleteImage(string TransactionID, string imageID);
    }
}
