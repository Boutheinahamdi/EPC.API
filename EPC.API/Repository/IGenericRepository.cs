namespace EPC.API.Repository
{
    public interface IGenericRepository <T> where T : class
    {
        Task<IEnumerable<T>> GetBuildingDataByTransactionID(string TransactionID);
         Task AddBuildingData(T entity);
        Task EditBuildingData(T entity);
        Task<bool> DeleteBuildingData(string TransactionID);
    }
}
