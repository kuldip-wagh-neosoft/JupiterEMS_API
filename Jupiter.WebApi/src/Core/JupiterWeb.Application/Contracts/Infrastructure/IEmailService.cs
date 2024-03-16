using System.Threading.Tasks;
using JupiterWeb.Application.Models.Mail;

namespace JupiterWeb.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
