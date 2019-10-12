#pragma checksum "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7f37a1d96b9ed4e93201e3f7737eedac9512a83"
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
            __builder.AddMarkupContent(0, "<h1>Student\'s Record</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 20 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
 if (Students == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 23 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
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
#line 31 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
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
#line 39 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
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
#line 44 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
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
#line 52 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
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
#line 55 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
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
#line 56 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
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
#line 57 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
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
#line 60 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
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
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row");
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-6");
            __builder.AddMarkupContent(62, "\r\n\r\n            ");
            __builder.OpenElement(63, "nav");
            __builder.AddAttribute(64, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "ul");
            __builder.AddAttribute(67, "class", "pagination");
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.AddMarkupContent(69, "<li class=\"page-item disabled\">\r\n                        <a class=\"page-link\" href=\"#\" tabindex=\"-1\">Previous</a>\r\n                    </li>\r\n\r\n");
#nullable restore
#line 73 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                     for (int i = 0; i < Students.TotalPages; i++)
                    {
                        int index = i + 1;

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                        ");
            __builder.OpenElement(71, "li");
            __builder.AddAttribute(72, "class", "page-item" + (
#nullable restore
#line 76 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                              index==PageIndex?" active":""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(74);
            __builder.AddAttribute(75, "class", "page-link");
            __builder.AddAttribute(76, "href", "javascript: void(0);");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                                                                               e => CurrentPage(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(79, "\r\n                                ");
                __builder2.AddContent(80, 
#nullable restore
#line 78 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                  index

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(81, "\r\n");
#nullable restore
#line 79 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                 if (index == PageIndex)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(82, "                                    ");
                __builder2.AddMarkupContent(83, "<span class=\"sr-only\">(current)</span>\r\n");
#nullable restore
#line 82 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(84, "                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 85 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(87, "\r\n                 \r\n\r\n\r\n                    ");
            __builder.AddMarkupContent(88, "<li class=\"page-item\">\r\n                        <a class=\"page-link\" href=\"#\">Next</a>\r\n                    </li>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col-6");
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "dropdown");
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.OpenElement(98, "button");
            __builder.AddAttribute(99, "class", "btn btn-secondary dropdown-toggle");
            __builder.AddAttribute(100, "type", "button");
            __builder.AddAttribute(101, "id", "dropdownMenuButton");
            __builder.AddAttribute(102, "data-toggle", "dropdown");
            __builder.AddAttribute(103, "aria-haspopup", "true");
            __builder.AddAttribute(104, "aria-expanded", "false");
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.AddContent(106, 
#nullable restore
#line 101 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                     pageSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "dropdown-menu");
            __builder.AddAttribute(111, "aria-labelledby", "dropdownMenuButton");
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 104 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                     for (int i = 5; i <= 20; i += 5)
                    {
                                int index = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "                        ");
            __builder.OpenElement(114, "a");
            __builder.AddAttribute(115, "class", "dropdown-item");
            __builder.AddAttribute(116, "href", "javascript: void(0);");
            __builder.AddAttribute(117, "onclick", 
#nullable restore
#line 107 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                                                                        pageSize = index

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(118, 
#nullable restore
#line 107 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
                                                                                                            index

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
#nullable restore
#line 108 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"

                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(120, "                    \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 115 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "F:\ASPNET\Blazor\BlazorDash\BlazorDash\Pages\FetchData.razor"
       
    #region pagination
    [Parameter]
    public int PageIndex { get; set; } = 1;

    [Parameter]
    public int pageSize { get; set; } = 5;
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
                studentsIQ.AsNoTracking(), PageIndex, pageSize);
    }

    public void  Next()
    {

    }

    public async void CurrentPage(int pageIndex)
    {
        PageIndex = pageIndex;

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
                    studentsIQ.AsNoTracking(), PageIndex, 5);
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
