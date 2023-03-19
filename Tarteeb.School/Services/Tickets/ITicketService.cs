using System.Collections.Generic;
using System.Threading.Tasks;
using Tarteeb.School.Models.Tickets;

namespace Tarteeb.School.Services.Tickets
{
    public interface ITicketService
    {
        public ValueTask<List<Ticket>> RetrieveAllTicketsAsync();
    }
}