using System.Collections.Generic;
using System.Threading.Tasks;
using Tarteeb.School.Brokers.ApiBrokers;
using Tarteeb.School.Models.Tickets;

namespace Tarteeb.School.Services.Tickets
{
    public class TicketService : ITicketService
    {
        private readonly IApiBroker apiBroker;

        public TicketService(IApiBroker apiBroker) =>
            this.apiBroker = apiBroker;

        public async ValueTask<List<Ticket>> RetrieveAllTicketsAsync() =>
            await this.apiBroker.GetAllTicketsAsync();
    }
}
