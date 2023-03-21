using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Tarteeb.School.Models.TicketViews;
using Tarteeb.School.Views.Bases;

namespace Tarteeb.School.Views.Components
{
    public partial class TicketComponent : ComponentBase
    {
        [Parameter]
        public List<TicketView> Tickets { get; set; }

        public TableBase TicketsTable { get; set; }
        public TableHeadBase TitleLabelCell { get; set; }
        public TableCellBase TitleValueCell { get; set; }
        public TableHeadBase DescriptionLabelCell { get; set; }
        public TableCellBase DescriptionValueCell { get; set; }
        public TableHeadBase DeadlineLabelCell { get; set; }
        public TableCellBase DeadlineValueCell { get; set; }
        public TableHeadBase StatusLabelCell { get; set; }
        public TableCellBase StatusValueCell { get; set; }
        public TableHeadBase PriorityLabelCell { get; set; }
        public TableCellBase PriorityValueCell { get; set; }
    }
}