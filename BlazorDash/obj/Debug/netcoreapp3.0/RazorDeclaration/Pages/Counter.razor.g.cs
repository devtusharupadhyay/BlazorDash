#pragma checksum "E:\BlazorDash\BlazorDash\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207788b8c210f73ecd02c22b4d4aceb5cc848ab6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDash.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\BlazorDash\BlazorDash\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\BlazorDash\BlazorDash\_Imports.razor"
using BlazorDash;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\BlazorDash\BlazorDash\_Imports.razor"
using BlazorDash.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "E:\BlazorDash\BlazorDash\Pages\Counter.razor"
       

    
   private int currentCount = 0;

    [Parameter]
    public int IncrementAmount { get; set; }

    private void IncrementCount()
    {
        IncrementAmount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
