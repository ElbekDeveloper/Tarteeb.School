using Microsoft.AspNetCore.Components;

namespace Tarteeb.School.Views.Bases
{
    public partial class TableHeadBase
    {
        [Parameter]
        public string Value { get; set; }
    }
}