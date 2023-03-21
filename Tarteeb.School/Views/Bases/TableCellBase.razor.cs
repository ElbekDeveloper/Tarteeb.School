using Microsoft.AspNetCore.Components;

namespace Tarteeb.School.Views.Bases
{
    public partial class TableCellBase : ComponentBase
    {
        [Parameter]
        public string Value { get; set; }
    }
}
