using System.Data;
using static Jupiter.Utility.Enums.GeneralEnum;
using Jupiter.Resource;
using System.Data.SqlClient;
using Microsoft.Extensions.Localization;
using Jupiter.Business.Core;
using Jupiter.Data.DataAccess.Core.UnitOfWork;
using Jupiter.Business.Models;
using Jupiter.Data.DataAccess.Core.Repositories;
using Jupiter.Data.DataAccess.Entity;
using Jupiter.Business.Core.Interface;
using Jupiter.Business.Core.ModelMapper;

namespace Jupiter.Business.Core.Implementation
{
    public class ExceptionService : IExceptionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperFactory _mapperFactory;
        //private readonly IStringLocalizer<Errors> _stringLocalizerError;
        private readonly Microsoft.Extensions.Configuration.IConfiguration configuration;
        private IRepository<MasterException> _repository { get; set; }
        private readonly IHelper _helper;

        /// <summary>
        /// Constructor for ExceptionService
        /// </summary>
        public ExceptionService(IUnitOfWork unitOfWork, IMapperFactory mapperFactory, //IStringLocalizer<Errors> stringLocalizerError,
                                 Microsoft.Extensions.Configuration.IConfiguration _configuration, IHelper helper)
        {
            _unitOfWork = unitOfWork;
            _mapperFactory = mapperFactory;
            _repository = _unitOfWork.GetRepository<MasterException>();
            configuration = _configuration;
            _helper = helper;
        }

        /// <summary>
        /// Log an exception to the database
        /// </summary>
        /// <param name="exception">The exception to log</param>
        /// <returns>A DBOperation enum indicating the success or failure of the operation</returns>
        public async Task<DBOperation> LogException(Exception exception)
        {
            try
            {
                var userId = _helper.GetLoggedInUser()?.UserId ?? 1;

                SqlParameter[] osqlParameter =
                {
                    new SqlParameter("@Message", exception.Message),
                    new SqlParameter("@Source",  exception.Source),
                    new SqlParameter("@InnerException", Convert.ToString(exception.InnerException)),
                    new SqlParameter("@StackTrace", Convert.ToString(exception.StackTrace)),
                    new SqlParameter("@CreatedBy",  userId)
                };

                await _repository.GetBySP(ProcedureMetastore.usp_InsertException, CommandType.StoredProcedure, osqlParameter);

                //var result = Convert.ToBoolean(dtOptions.Rows[0][0]);
                //if (result)
                return DBOperation.Success;
            }
            catch (Exception ex)
            {
                return DBOperation.Error;
            }
        }
    }
}
