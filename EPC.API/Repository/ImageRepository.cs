using EPC.Model.DTOs;

namespace EPC.API.Repository
{
    public class ImageRepository : IImageRepository
    {
        public async Task AddImage(ImageDTO image)
        {
            await Task.CompletedTask;
        }

        public async Task<bool> DeleteImage(string TransactionID, string imageID)
        {

            await Task.CompletedTask;
            return true;
        }

        public async Task<IEnumerable<ImageDTO>> GetImageByIDs(string TransactionID, string imageID)
        {
            var skeletonEntity = new ImageDTO();
            var result = new List<ImageDTO> { skeletonEntity };
            return await Task.FromResult(result);
        }
    }
}
