using System.Collections.Generic;
using System.Threading.Tasks;
using JupiterWeb.Domain.Entities;
using JupiterWeb.Application.Features.GloblaFilters;
using JupiterWeb.Application.Features.Branchs.Queries.GetBranchListWithPagination;
using JupiterWeb.Application.Features.Branchs.Queries.GetBranchDetail;
using JupiterWeb.Domain.ViewModel;

namespace JupiterWeb.Application.Contracts.Persistence
{
    public interface IBranchRepository : IAsyncRepository<Branch>
    {
        Task<List<Branch>> GetBranchesWithEvents(bool includePassedEvents);
        //Task<Branch> AddBranch(Branch category);

        Task<GlobalSeachResponse> GetBranchListWithPaginationGlobal(BranchSearchFilters searchBranch);

        Task<BranchDetailViewModel> GetBranchDetails(GetBranchDetailQuery branchDetail);

        Task<Branch> GetBranchByName(string name);
    }
}
