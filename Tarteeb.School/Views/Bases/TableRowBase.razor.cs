using Microsoft.AspNetCore.Components;

namespace Tarteeb.School.Views.Bases
{
    public partial class TableRowBase : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
