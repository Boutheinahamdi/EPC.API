namespace EPC.API.Repository
{
    public class EPCManagementRepository : IEPCManagementRepository
    {
        public async Task<bool> DeleteBuildingData(string TransactionID)
        {
            await Task.CompletedTask;
            return true;
        }

        public async Task EPCCreationStart(string TransactionID)
        {
            await Task.CompletedTask;
        }
    }
}
