using JupiterWeb.Domain.Entities;
using JupiterWeb.Domain.ViewModel;
using JupiterWeb.Application.Features.GloblaFilters;

namespace JupiterWeb.Application.Contracts.Persistence
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<User> GetUserByEmailPassword(string email, string password);
        Task<User> GetUserByEmail(string email);

        Task<int> UpdateUserPassword(int id, string password);

        Task<string> GetEncryptPassword(string inputValue);

        Task<string> GetDecryptedTextFromPassword(string decryptValue);

        //Task<GlobalSeachResponse> GetUserListWithPaginationGlobal(UserSearchFilters searchUser);

        //Task<UserDetailViewModel> GetUserDetails(GetUserDetailQuery userDetail);
        Task<UserDetailViewModel> GetUserDetailsById(int Id);

        Task<int> SetForgotPassword(int id, string ForgotPasswordToken);

        Task<string> UpsertUserAccountDetails(User request);
    }
}
