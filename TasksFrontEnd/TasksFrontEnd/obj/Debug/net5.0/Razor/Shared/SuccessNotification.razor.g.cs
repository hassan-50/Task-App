#pragma checksum "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Shared\SuccessNotification.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e4af0bfc9a55457c76ec273456751a0ee190a59"
// <auto-generated/>
#pragma warning disable 1591
namespace TasksFrontEnd.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
    public partial class SuccessNotification : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 1 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Shared\SuccessNotification.razor"
                   _modalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 1 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Shared\SuccessNotification.razor"
                                                                            _modalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.AddMarkupContent(12, "<h5 class=\"modal-title\">Success</h5>\r\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Shared\SuccessNotification.razor"
                                                              Hide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "aria-label", "Close");
            __builder.AddMarkupContent(18, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "modal-body");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, 
#nullable restore
#line 11 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Shared\SuccessNotification.razor"
                    bodyString

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, ".");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "modal-footer");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "class", "btn btn-success");
            __builder.AddAttribute(31, "data-dismiss", "modal");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Shared\SuccessNotification.razor"
                                                                                             Hide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Close");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Shared\SuccessNotification.razor"
 if (_showBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<div class=\"modal-backdrop fade show\"></div>");
#nullable restore
#line 22 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Shared\SuccessNotification.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
