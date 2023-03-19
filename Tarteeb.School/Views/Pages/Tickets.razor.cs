using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Tarteeb.School.Models.Tickets;
using Tarteeb.School.Services.Tickets;

namespace Tarteeb.School.Views.Pages
{
    public partial class Tickets
    {
        [Inject]
        public ITicketService TicketService { get; set; }

        private List<Ticket> tickets;

        protected override async Task OnInitializedAsync() =>
            tickets = await TicketService.RetrieveAllTicketsAsync();
    }
}