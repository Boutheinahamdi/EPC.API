namespace EPC.API.Repository
{
    public interface IGenericRepository <T> where T : class
    {
        Task<IEnumerable<T>> GetBuildingInformationByTransactionID(string TransactionID);
         Task AddBuildingInformation(T entity);
        Task EditBuildingInformation(T entity);
        Task<bool> DeleteBuildingInformation(string TransactionID);
    }
}
