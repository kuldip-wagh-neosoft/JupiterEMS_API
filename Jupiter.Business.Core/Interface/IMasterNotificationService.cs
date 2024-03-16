using Jupiter.Business.Models;
using Jupiter.Utility.Enums;
using static Jupiter.Utility.Enums.GeneralEnum;

namespace Jupiter.Business.Core.Interface
{
    public interface IMasterNotificationService
    {
        Task<DBOperation> SendEmail(SendNotificationModel notificationModel);
        Task<DBOperation> SendEmail2(SendNotificationModel notificationModel);
        SendNotificationModel GetValuationNotificationData(RecepientActionEnum subjectEnum, int valiadtionRequestId);
        List<MasterNotificationEntitty> GetAll(int userId, int? valId, int? pagenum);
        Task<DBOperation> UpdateNotification(int notificationid, int readBy);
        void UpdateValuationRequestStatus(int newStatusId, int valuationRequestId);
        int GetAllCount(int userId, int? valId);
    }
}
