using Microsoft.AspNetCore.Components;

namespace Tarteeb.School.Views.Bases
{
    public partial class TableBase : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}