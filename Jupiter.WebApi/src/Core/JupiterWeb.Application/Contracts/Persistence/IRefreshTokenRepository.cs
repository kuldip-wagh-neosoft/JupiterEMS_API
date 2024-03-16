using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JupiterWeb.Domain.Entities;

namespace JupiterWeb.Application.Contracts.Persistence
{
    public interface IRefreshTokenRepository : IAsyncRepository<RefreshToken>
    {
        Task<RefreshToken> GetRefreshTokenByToken(string token);
    }
}
