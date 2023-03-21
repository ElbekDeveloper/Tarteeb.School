using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using Tarteeb.School;
using Tarteeb.School.Views.Components;

namespace Tarteeb.School.Views.Components
{
    public partial class ContainerBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}