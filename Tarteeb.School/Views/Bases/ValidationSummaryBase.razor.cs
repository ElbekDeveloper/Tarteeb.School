// --------------------------------------------------------------- 
// Copyright (c) Microsoft Corporation. All rights reserved. 
// ---------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Tarteeb.School.Views.Bases
{
    public partial class ValidationSummaryBase : ComponentBase
    {
        [Parameter]
        public IDictionary ValidationData { get; set; }

        [Parameter]
        public string Key { get; set; }

        [Parameter]
        public string Color { get; set; }

        public IEnumerable<string> Errors
        {
            get => ValidationData?[Key] as IEnumerable<string>;
            set => Errors = value;
        }
    }
}
