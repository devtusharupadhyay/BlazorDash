#pragma checksum "E:\BlazorDash\BlazorDash\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4720d3407fbbc435962d3153778e31f9f174322f"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 4 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
using BlazorDash.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
using BlazorDash.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
using BlazorDash.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
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
            __builder.AddMarkupContent(0, "<h1>Student\'s Record</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 20 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
 if (Students == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 23 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "thead");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n\r\n                ");
            __builder.OpenElement(12, "th");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                        e => Sort("last_name")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn-sort");
            __builder.AddMarkupContent(17, "\r\n                        Last Name\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n\r\n\r\n                ");
            __builder.OpenElement(20, "th");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                        e => Sort("first_mid_name")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn-sort");
            __builder.AddMarkupContent(25, "\r\n                        First Mid Name\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "th");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                        e => Sort("enrollment_date")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn-sort");
            __builder.AddMarkupContent(33, "\r\n                        Enrollment Date\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "tbody");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 52 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
             foreach (var student in Students)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                ");
            __builder.OpenElement(41, "tr");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 55 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
                         student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 56 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
                         student.FirstMidName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 57 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
                         student.EnrollmentDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 60 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.AddContent(56, "    ");
            __builder.OpenElement(57, "nav");
            __builder.AddAttribute(58, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "ul");
            __builder.AddAttribute(61, "class", "pagination");
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.AddMarkupContent(63, "<li class=\"page-item disabled\">\r\n                <a class=\"page-link\" href=\"#\" tabindex=\"-1\">Previous</a>\r\n            </li>\r\n\r\n");
#nullable restore
#line 70 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
             for (int i = 0; i < Students.TotalPages; i++)
            {
                int index = i + 1;

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "                ");
            __builder.OpenElement(65, "li");
            __builder.AddAttribute(66, "class", "page-item");
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(68);
            __builder.AddAttribute(69, "class", "page-link");
            __builder.AddAttribute(70, "href", "javascript: void(0);");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                                                                       e => CurrentPage(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.AddContent(74, 
#nullable restore
#line 75 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
                          index

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 78 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.AddMarkupContent(79, "<li class=\"page-item active\">\r\n                <a class=\"page-link\" href=\"#\">2 <span class=\"sr-only\">(current)</span></a>\r\n            </li>\r\n            ");
            __builder.AddMarkupContent(80, "<li class=\"page-item\"><a class=\"page-link\" href=\"#\">3</a></li>\r\n\r\n\r\n            ");
            __builder.AddMarkupContent(81, "<li class=\"page-item\">\r\n                <a class=\"page-link\" href=\"#\">Next</a>\r\n            </li>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 91 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "E:\BlazorDash\BlazorDash\Pages\FetchData.razor"
       
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
