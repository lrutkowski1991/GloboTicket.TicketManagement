using GloboTicket.TicketManagement.Application.Models.Mail;

namespace GloboTicket.TicketManagement.Application.Contracts.Infrasctructre
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
