using MediatR;
using System;
using System.Collections.Generic;
using JupiterWeb.Application.Responses;
using JupiterWeb.Domain.ViewModel;

namespace JupiterWeb.Application.Features.Branchs.Queries.GetBranchDetail
{
    /// <summary>
    /// Added by YReddy on 08/05/2022
    /// Class used to hold all user related filters
    /// </summary>
    public class GetBranchDetailQuery : IRequest<Response<BranchDetailViewModel>>
    {
        public int? Id { get; set; }
        public bool? status { get; set; }
        public string Name { get; set; }
    }
}
