#pragma checksum "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39e9ee39d80a60025c80c2b31bc9b5e578b487c0"
// <auto-generated/>
#pragma warning disable 1591
namespace HRM.App.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-qm9bbvg7dv");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-qm9bbvg7dv");
            __builder.OpenComponent<HRM.App.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-qm9bbvg7dv");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-qm9bbvg7dv>\r\n            &nbsp;\r\n</div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-qm9bbvg7dv");
            __builder.AddContent(15, 
#nullable restore
#line 15 "D:\Labs\.Net\BlazorLab\3.ServerSideDm\HRM\HRM.App\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
