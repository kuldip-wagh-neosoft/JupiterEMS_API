using System;
using System.Threading.Tasks;
using static Jupiter.Utility.Enums.GeneralEnum;

namespace Jupiter.Business.Core.Interface
{
    public interface IExceptionService
    {
        Task<DBOperation> LogException(Exception exception);
    }
}
