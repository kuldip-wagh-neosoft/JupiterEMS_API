using Jupiter.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Jupiter.Utility.Enums.GeneralEnum;

namespace Jupiter.Business.Core.Interface
{
    public interface IMasterUserService
    {
        Task<UserSessionEntity> Login(LoginViewModel oLogin);
       
        Task<DBOperation> DeleteUser(int id);
        Task<bool> CheckEmailAddressExists(string emailAddress);
        Task<DBOperation> ForgotPassword(ForgotPasswordViewModel forgotPasswordViewModel);
        Task<string> ResetPassword(MasterUserResetPasswordEntity entity);
        Task<bool> IsTokenValid(string token);

        Task<List<MasterRoleModel>> GetRoleList();
        Task<DBOperation> Delete(int id);
        Task<DBOperation> ChangePassword(ChangePasswordModel changePasswordModel);
        Task<GlobalAuditFields?> GetGlobalAuditFields(int TableKeyId, string TableName);

        Task<List<MasterUserModel>> GetAllUserList();
        Task<bool> IsEmailExists(string email, int? userId);
        Task<DBOperation> DeleteDocument(int id);
    }
}