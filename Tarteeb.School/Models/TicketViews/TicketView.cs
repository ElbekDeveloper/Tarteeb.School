using System;

namespace Tarteeb.School.Models.TicketViews
{
    public class TicketView
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PriorityView Priority { get; set; }
        public DateTimeOffset Deadline { get; set; }
        public TicketStatusView Status { get; set; }
    }
}
