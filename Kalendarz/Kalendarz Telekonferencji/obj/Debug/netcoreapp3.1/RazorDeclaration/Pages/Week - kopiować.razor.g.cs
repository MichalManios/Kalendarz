#pragma checksum "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\Pages\Week - kopiować.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09627ee041bc4c3623b1636a1fe6597648f828ca"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Kalendarz_Telekonferencji.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\_Imports.razor"
using Kalendarz_Telekonferencji;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\_Imports.razor"
using Kalendarz_Telekonferencji.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/week")]
    public partial class Week___kopiować : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji\Kalendarz Telekonferencji\Pages\Week - kopiować.razor"
 

    void GoMonth()
    {
        navigationManager.NavigateTo("/", true);
    }

    void GoWeek()
    {
        navigationManager.NavigateTo("/week", true);
    }

    void GoDay()
    {
        navigationManager.NavigateTo("/day", true);
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
