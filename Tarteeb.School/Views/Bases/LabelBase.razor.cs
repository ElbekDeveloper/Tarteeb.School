using Microsoft.AspNetCore.Components;

namespace Tarteeb.School.Views.Bases
{
    public partial class LabelBase : ComponentBase
    {
        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public string ClassName { get; set; }
    }
}