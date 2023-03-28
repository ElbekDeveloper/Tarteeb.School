using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Inputs.Slider.Internal;

namespace Tarteeb.School.Views.Bases
{
    public partial class ContainerBase
    {
        [Parameter]
        public string CssClass { get; set; } = "container";

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}