using Microsoft.AspNetCore.Mvc;

namespace EPC.API.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class,new()
    {
        public async Task AddBuildingInformation(T entity)
        {
            await Task.CompletedTask;

        }

        public async Task<bool> DeleteBuildingInformation(string TransactionID)
        {
            await Task.CompletedTask;
            return true;
        }

        public async Task EditBuildingInformation(T entity)
        {
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<T>> GetBuildingInformationByTransactionID(string TransactionID)
        {
            var skeletonEntity = new T();
            var result = new List<T> { skeletonEntity };
            return await Task.FromResult(result);
        }
    }
}
