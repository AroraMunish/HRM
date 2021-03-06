#pragma checksum "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "047573ff0351ca74bb76cb89c617ea3f14c2c1b4"
// <auto-generated/>
#pragma warning disable 1591
namespace HRM.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\_Imports.razor"
using HRM.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\_Imports.razor"
using HRM.App.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeoverview")]
    public partial class EmployeeOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"d-flex justify-content-center border rounded border-success bg-primary text-white font-weight-bold\"><p>&nbsp;List of Employees</p></div>\r\n");
            __builder.AddMarkupContent(1, "<div><p class=\"p-0 m-0\">&nbsp;</p></div>");
#nullable restore
#line 11 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "border rounded border-success");
            __builder.OpenElement(5, "a");
            __builder.AddAttribute(6, "href", 
#nullable restore
#line 18 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
               $"employeeedit"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "class", "btn btn-dark table-btn");
            __builder.AddMarkupContent(8, "<i>Add Employee</i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table table-striped");
            __builder.AddMarkupContent(12, @"<thead class=""bg-primary text-white""><tr><th>Employee ID</th>
                <th>First name</th>
                <th>Last name</th>
                <th colspan=""2"" class=""text-center"">Details</th>
                <th>Binding Ex</th></tr></thead>
        ");
            __builder.OpenElement(13, "tbody");
#nullable restore
#line 32 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
             foreach (var employee in Employees)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 35 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
                         employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 36 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
                         employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 37 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 39 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
                                   $"employeedetail/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-success table-btn");
            __builder.AddMarkupContent(28, "<i class=\"fas fa-info-circle\">View Details</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", 
#nullable restore
#line 44 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
                                   $"employeeedit/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "class", "btn btn-danger table-btn");
            __builder.AddMarkupContent(34, "<i class=\"fas fa-info-circle\">Edit</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", 
#nullable restore
#line 49 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
                                   $"bindingex/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(40, "<i class=\"fas fa-info-circle\">Display Binding</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Pages\EmployeeOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
