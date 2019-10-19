#pragma checksum "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b458b3b016ce3a20a93e4b4a2e613b89cf72fdea"
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
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
       
    #region pagination
    [Parameter]
    public int PageIndex { get; set; } = 1;

    [Parameter]
    public int pageSize { get; set; } = 5;
    #endregion




    [Parameter]
    public string sortOrderState { get; set; } = "last_name_asc";

    [Parameter]
    public string LastNameSort { get; set; }

    [Parameter]
    public string FirstMidNameSort { get; set; }

    [Parameter]
    public string EnrollmentDateSort { get; set; }


    public IQueryable<Student> studentsIQ { get; set; }
    public PaginatedList<Student> Students { get; set; }

    public void Sort(string order = "")
    {


        if (order == "last_name")
        {
            if (sortOrderState.Contains("asc"))
            {
                sortOrderState = $"{order}_desc";
            }
            else
            {
                sortOrderState = $"{order}_asc";
            }
        }
        if (order == "first_mid_name")
        {
            if (sortOrderState.Contains("asc"))
            {
                sortOrderState = $"{order}_desc";
            }
            else
            {
                sortOrderState = $"{order}_asc";
            }
        }
        if (order == "enrollment_date")
        {
           if (sortOrderState.Contains("asc"))
            {
                sortOrderState = $"{order}_desc";
            }
            else
            {
                sortOrderState = $"{order}_asc";
            }
        }


        if (sortOrderState.Contains("last_name"))
        {
            if (sortOrderState.Contains("asc"))
            {
                studentsIQ = studentsIQ.OrderBy(order => order.LastName);
                sortOrderState = "last_name_asc";

            }
            else
            {
                studentsIQ = studentsIQ.OrderByDescending(order => order.LastName);
                sortOrderState = "last_name_desc";
            }
        }


        if (sortOrderState.Contains("first_mid_name"))
        {
            if (sortOrderState.Contains("asc"))
            {
                studentsIQ = studentsIQ.OrderBy(order => order.FirstMidName);
                sortOrderState = "first_mid_name_asc";


            }
            else
            {
                studentsIQ = studentsIQ.OrderByDescending(order => order.FirstMidName);
                sortOrderState = "first_mid_name_desc";

            }
        }


        if (sortOrderState.Contains("enrollment_date"))
        {
            if (sortOrderState.Contains("asc"))
            {
                studentsIQ = studentsIQ.OrderBy(order => order.EnrollmentDate);
                sortOrderState = "enrollment_date_asc";


            }
            else
            {
                studentsIQ = studentsIQ.OrderByDescending(order => order.EnrollmentDate);
                sortOrderState = "enrollment_date_desc";

            }
        }




        Students = PaginatedList<Student>.CreateAsync(
                studentsIQ.AsNoTracking(), PageIndex, pageSize);
    }

    public async void Next()
    {
        if (Students.HasNextPage)
        {
            PageIndex = PageIndex + 1;
            await GetAllStudents();
        }

    }

    public async void CurrentPage(int pageIndex)
    {
        PageIndex = pageIndex;

        await GetAllStudents();
    }

    public async void Previous()
    {
        if (Students.HasPreviousPage)
        {
            PageIndex = PageIndex - 1;
            await GetAllStudents();
        }

    }

    public async void ChangePageSize(ChangeEventArgs e)
    {
        pageSize = Convert.ToInt32(e.Value.ToString());
        await GetAllStudents();
    }

    public async Task GetAllStudents()
    {
        try
        {

            studentsIQ = StudentService.GetStudentsQueryable();

            Students = PaginatedList<Student>.CreateAsync(
                    studentsIQ.AsNoTracking(), PageIndex, pageSize);

            //mentain sort state
            Sort();
        }
        catch (Exception ex)
        {

            await JsRuntime.InvokeAsync<string>("alert", $"{ex.Message}");

        }


    }


    protected async override Task OnInitializedAsync()
    {
        await GetAllStudents();

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService StudentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591