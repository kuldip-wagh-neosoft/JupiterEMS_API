using Jupiter.Business.Models;
using Jupiter.Data.DataAccess.Entity;
using static Jupiter.Utility.Enums.GeneralEnum;

namespace JupiterWeb.Application.Contracts.Persistence
{
    public interface IMasterCityRepository : IAsyncRepository<MasterCity>
    {
        Task<DBOperation> Upsert(MasterCityEntity entityUser);
        //Task<MasterCity> GetById(int id);
        Task<DataTableResponseModel> GetAll(DataTableAjaxPostModel model);
        Task<DBOperation> Delete(int id);
    }
}
