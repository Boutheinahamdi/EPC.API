namespace EPC.API.Repository
{
    public interface IEPCManagementRepository
    {
        Task<bool> DeleteBuildingData(string TransactionID);
        Task EPCCreationStart(string TransactionID);

    }
}
