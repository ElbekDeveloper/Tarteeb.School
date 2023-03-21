using System.Collections.Generic;
using System.Threading.Tasks;
using Tarteeb.School.Models.TicketViews;

namespace Tarteeb.School.Services.Views.TicketViews
{
    public interface ITicketViewService
    {
        ValueTask<List<TicketView>> RetrieveTicketViewAsync();
    }
}