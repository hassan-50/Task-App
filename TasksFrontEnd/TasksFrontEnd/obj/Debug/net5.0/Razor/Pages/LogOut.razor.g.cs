#pragma checksum "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\LogOut.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a65c34dddec3c32c4c4fb93a5a92ef7c63b7e3d"
// <auto-generated/>
#pragma warning disable 1591
namespace TasksFrontEnd.Pages
{
    #line hidden
#nullable restore
#line 1 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\_Imports.razor"
using TasksFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\_Imports.razor"
using TasksFrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\LogOut.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\LogOut.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\LogOut.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\LogOut.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\LogOut.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\LogOut.razor"
using TasksFrontEnd.HttpRepository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/logout")]
    public partial class LogOut : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    body {\r\n        background-color: gray;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\LogOut.razor"
       
    [Inject]
    public IAuthenticationService AuthenticationService { get; set; }
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    protected async override Task OnInitializedAsync()
    {
        await AuthenticationService.Logout();
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
