// --------------------------------------------------------------- 
// Copyright (c) Microsoft Corporation. All rights reserved. 
// ---------------------------------------------------------------

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Tarteeb.School.Views.Bases
{
    public partial class TextBoxBase : ComponentBase
    {
        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public string Placeholder { get; set; }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        [Parameter]
        public bool IsDisabled { get; set; }

        [Parameter]
        public string CssClass { get; set; }

        [Parameter]
        public bool Multiline { get; set; }

        public bool IsEnabled => IsDisabled is false;

        public Task SetValueAsync(string value) =>
        InvokeAsync(async () =>
        {
            Value = value;
            await ValueChanged.InvokeAsync(Value);
        });

        private Task OnValueChanged(ChangeEventArgs changeEventArgs)
        {
            Value = changeEventArgs.Value.ToString();

            return ValueChanged.InvokeAsync(Value);
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
