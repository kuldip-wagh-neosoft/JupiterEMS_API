using MediatR;
using System.Collections.Generic;
using JupiterWeb.Application.Responses;
using JupiterWeb.Application.Features.GloblaFilters;

namespace JupiterWeb.Application.Features.Branchs.Queries.GetBranchListWithPagination
{
    public class BranchSearchFilters : GlobalSeachFilter, IRequest<Response<GlobalSeachResponse>>
    {
        public bool? IsActive { get; set; }
        public string Letter { get; set; }
        public int? Id { get; set; }
    }
}
