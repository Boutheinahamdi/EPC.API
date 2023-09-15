using Microsoft.AspNetCore.Mvc;

namespace EPC.API.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class,new()
    {
        public async Task AddBuildingData(T entity)
        {
            await Task.CompletedTask;

        }

        public async Task<bool> DeleteBuildingData(string TransactionID)
        {
            await Task.CompletedTask;
            return true;
        }

        public async Task EditBuildingData(T entity)
        {
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<T>> GetBuildingDataByTransactionID(string TransactionID)
        {
            var skeletonEntity = new T();
            var result = new List<T> { skeletonEntity };
            return await Task.FromResult(result);
        }
    }
}
