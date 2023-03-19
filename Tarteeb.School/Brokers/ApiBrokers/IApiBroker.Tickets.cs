using System.Collections.Generic;
using System.Threading.Tasks;
using Tarteeb.School.Models.Tickets;

namespace Tarteeb.School.Brokers.ApiBrokers
{
    public partial interface IApiBroker
    {
        ValueTask<List<Ticket>> GetAllTicketsAsync();
    }
}
