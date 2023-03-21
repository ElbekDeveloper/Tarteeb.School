using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Tarteeb.School.Models.TicketViews;
using Tarteeb.School.Services.Views.TicketViews;

namespace Tarteeb.School.Views.Pages
{
    public partial class Tickets
    {
        [Inject]
        public ITicketViewService TicketViewService { get; set; }

        private List<TicketView> ticketViews;

        protected override async Task OnInitializedAsync() =>
            ticketViews = await TicketViewService.RetrieveTicketViewAsync();
    }
}