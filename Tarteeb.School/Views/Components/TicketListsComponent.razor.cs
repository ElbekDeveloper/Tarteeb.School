using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Tarteeb.School.Models.States;
using Tarteeb.School.Models.TicketViews;
using Tarteeb.School.Services.Views.TicketViews;

namespace Tarteeb.School.Views.Components
{
    public partial class TicketListsComponent : ComponentBase
    {
        [Inject]
        public ITicketViewService TicketViewService { get; set; }

        public State CurrentState { get; set; }
        public List<TicketView> TicketViews { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                this.TicketViews = await this.TicketViewService.RetrieveTicketViewAsync();
                this.CurrentState = State.Content;
            }
            catch (Exception exception)
            {
                this.CurrentState = State.Error;
            }

            StateHasChanged();
        }
    }
}