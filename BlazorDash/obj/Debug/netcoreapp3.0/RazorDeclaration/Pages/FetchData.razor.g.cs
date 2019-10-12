#pragma checksum "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4720d3407fbbc435962d3153778e31f9f174322f"
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
#line 1 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\_Imports.razor"
using BlazorDash;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\_Imports.razor"
using BlazorDash.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
using BlazorDash.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
using BlazorDash.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
using BlazorDash.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
using BlazorDash.Utility;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata/{sortOrder}")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
       
    #region pagination
    [Parameter]
    public int? PageIndex { get; set; }

    [Parameter]
    public int pageSize { get; set; }
    #endregion


    [Parameter]
    public string sortOrder { get; set; }

    [Parameter]
    public string LastNameSort { get; set; }

    [Parameter]
    public string FirstMidNameSort { get; set; }

    [Parameter]
    public string EnrollmentDateSort { get; set; }


    public IQueryable<Student> studentsIQ { get; set; }
    public PaginatedList<Student> Students { get; set; }

    public async void Sort(string order)
    {
        sortOrder = (sortOrder == "sort_desc" ? "sort_asc" : "sort_desc");

        switch (order)
        {

            case "last_name":

                if (sortOrder == "sort_desc")
                {
                    studentsIQ = studentsIQ.OrderByDescending(order => order.LastName);
                }

                if (sortOrder == "sort_asc")
                {
                    studentsIQ = studentsIQ.OrderBy(order => order.LastName);
                }
                break;

            case "first_mid_name":
                if (sortOrder == "sort_desc")
                {
                    studentsIQ = studentsIQ.OrderByDescending(order => order.FirstMidName);
                }

                if (sortOrder == "sort_asc")
                {
                    studentsIQ = studentsIQ.OrderBy(order => order.FirstMidName);
                }
                break;

            case "enrollment_date":
                if (sortOrder == "sort_desc")
                {
                    studentsIQ = studentsIQ.OrderByDescending(order => order.EnrollmentDate);
                }

                if (sortOrder == "sort_asc")
                {
                    studentsIQ = studentsIQ.OrderBy(order => order.EnrollmentDate);
                }
                break;

            default:

                sortOrder = "sort_asc";
                studentsIQ = studentsIQ.OrderBy(order => order.LastName);
                break;


        }

        Students = await PaginatedList<Student>.CreateAsync(
                studentsIQ.AsNoTracking(), PageIndex ?? 1, pageSize);
    }

    public void  Next()
    {

    }

    public async void CurrentPage(int pageIndex)
    {
        PageIndex = pageIndex;
        PageIndex = PageIndex ?? 1;

        await GetAllStudents();
    }

    public void  Previous()
    {

    }

    public async Task GetAllStudents()
    {
        try
        {
            IQueryable<Student> studentsIQ =  StudentService.GetStudentsQueryable();

            Students = await PaginatedList<Student>.CreateAsync(
                    studentsIQ.AsNoTracking(), 1, 5);
        }
        catch (Exception ex)
        {

            await JsRuntime.InvokeAsync<string>("alert", $"{ex.Message}");

        }


    }


    protected async override Task OnInitializedAsync()
    {
            await    GetAllStudents();

    }
   



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService StudentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
