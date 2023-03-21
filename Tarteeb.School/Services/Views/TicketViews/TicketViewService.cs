using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarteeb.School.Brokers.DateTimes;
using Tarteeb.School.Brokers.Loggings;
using Tarteeb.School.Models.Tickets;
using Tarteeb.School.Models.TicketViews;
using Tarteeb.School.Services.Foundations.Users;
using Tarteeb.School.Services.Tickets;

namespace Tarteeb.School.Services.Views.TicketViews
{
    public class TicketViewService : ITicketViewService
    {
        private readonly ITicketService ticketService;
        private readonly IUserService userService;
        private readonly IDateTimeBroker broker;
        private readonly ILoggingBroker loggingBroker;

        public TicketViewService(
            ITicketService ticketService,
            IUserService userService,
            IDateTimeBroker broker,
            ILoggingBroker loggingBroker)
        {
            this.ticketService = ticketService;
            this.userService = userService;
            this.broker = broker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<List<TicketView>> RetrieveTicketViewAsync()
        {
            List<Ticket> tickets = await this.ticketService.RetrieveAllTicketsAsync();

            return tickets.Select(AsTicketViews).ToList();
        }

        private static Func<Ticket, TicketView> AsTicketViews =>
        ticket => new TicketView
        {
            Id = ticket.Id,
            Title = ticket.Title,
            Description = ticket.Description,
            Priority = (PriorityView)ticket.Priority,
            Deadline = ticket.Deadline,
            Status = (TicketStatusView)ticket.Status
        };
    }
}
