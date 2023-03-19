using System.Collections.Generic;
using System.Threading.Tasks;
using Tarteeb.School.Models.Tickets;

namespace Tarteeb.School.Brokers.ApiBrokers
{
    public partial class ApiBroker
    {
        public async ValueTask<List<Ticket>> GetAllTicketsAsync() =>
            await GetAsync< List<Ticket>>("api/Tickets");
    }
}
