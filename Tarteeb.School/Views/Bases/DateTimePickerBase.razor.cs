using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Calendars;
using Syncfusion.Blazor.Inputs;

namespace Tarteeb.School.Views.Bases
{
    public partial class DateTimePickerBase : ComponentBase
    {
        [Parameter]
        public string CssClass { get; set; }

        [Parameter]
        public bool IsDisabled { get; set; }

        [Parameter]
        public EventCallback<DateTimeOffset> ValueChanged { get; set; }

        [Parameter]
        public DateTimeOffset Value { get; set; }

        public bool IsEnabled => IsDisabled is false;

        public async Task SetValue(DateTimeOffset value)
        {
            this.Value = value;
            await ValueChanged.InvokeAsync(this.Value);
        }

        private async Task OnValueChanged(
            ChangedEventArgs<DateTimeOffset> changeEventArgs)
        {
            await SetValue(changeEventArgs.Value);
        }

        public void Disable()
        {
            IsDisabled = true;
            InvokeAsync(StateHasChanged);
        }

        public void Enable()
        {
            IsDisabled = false;
            InvokeAsync(StateHasChanged);
        }

    }
}