#pragma checksum "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c8d9716d9aa2fd3d3ef3600da0c57617f2accbc"
// <auto-generated/>
#pragma warning disable 1591
namespace TasksFrontEnd.Pages
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
#nullable restore
#line 2 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
using TasksFrontEnd.models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
using TasksFrontEnd.HttpRepository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createTask")]
    public partial class CreateTask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Create Task Form</h2>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                 _product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                          Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group row");
                __builder2.AddMarkupContent(10, "<label for=\"name\" class=\"col-md-2 col-form-label\">Title:</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "name");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                                                   _product.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _product.Title = __value, _product.Title))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _product.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __Blazor.TasksFrontEnd.Pages.CreateTask.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 12 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                      () => _product.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "<label for=\"Text\" class=\"col-md-2 col-form-label\">Text:</label>\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "Text");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                                                   _product.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _product.Text = __value, _product.Text))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _product.Text));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __Blazor.TasksFrontEnd.Pages.CreateTask.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 19 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                      () => _product.Text

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group row");
                __builder2.AddMarkupContent(40, "<label for=\"Comment\" class=\"col-md-2 col-form-label\">Comment:</label>\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "id", "comment");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                                                      _product.Comment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _product.Comment = __value, _product.Comment))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _product.Comment));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __Blazor.TasksFrontEnd.Pages.CreateTask.TypeInference.CreateValidationMessage_2(__builder2, 50, 51, 
#nullable restore
#line 26 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                      () => _product.Comment

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group row");
                __builder2.AddMarkupContent(55, "<label for=\"image\" class=\"col-md-2 col-form-label\">Image:</label>\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-md-10");
                __builder2.OpenComponent<TasksFrontEnd.Shared.ImageUpload>(58);
                __builder2.AddAttribute(59, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 32 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                   AssignImageUrl

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group row");
                __builder2.AddMarkupContent(63, "<label for=\"type\" class=\"col-md-2 col-form-label\">Task Type:</label>\r\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-md-10");
                __Blazor.TasksFrontEnd.Pages.CreateTask.TypeInference.CreateInputRadioGroup_3(__builder2, 66, 67, "type", 68, "form-control", 69, 
#nullable restore
#line 38 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                                    _product.Type

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _product.Type = __value, _product.Type)), 71, () => _product.Type, 72, (__builder3) => {
                    __Blazor.TasksFrontEnd.Pages.CreateTask.TypeInference.CreateInputRadio_4(__builder3, 73, 74, 
#nullable restore
#line 39 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                   0

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(75, "<span style=\"padding-left: 5px\"></span>Technical <br>\r\n                ");
                    __Blazor.TasksFrontEnd.Pages.CreateTask.TypeInference.CreateInputRadio_5(__builder3, 76, 77, 
#nullable restore
#line 40 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                                   1

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(78, "<span style=\"padding-left: 5px\"></span>Business <br>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.AddMarkupContent(80, "<div class=\"row\"><div class=\"col-md-12 text-right\"><button type=\"submit\" class=\"btn btn-success\">Create</button></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.OpenComponent<TasksFrontEnd.Shared.SuccessNotification>(82);
            __builder.AddComponentReferenceCapture(83, (__value) => {
#nullable restore
#line 51 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
                           _notification = (TasksFrontEnd.Shared.SuccessNotification)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.AddMarkupContent(85, "<style>\r\n    body {\r\n        background-color: gray;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\dell\source\repos\TasksFrontEnd\TasksFrontEnd\Pages\CreateTask.razor"
       
    private TaskReq _product = new TaskReq();
    private SuccessNotification _notification;
    [Inject]
    public ITaskHttpRepository TaskRepo { get; set; }
    List<TypeMode> mylist = new List<TypeMode> {
        new TypeMode { type = false, label = "Technicalll" },
        new TypeMode { type = true, label = "Business" },
    };

    private async Task Create()
    {
        _product.Checked = false;
        await TaskRepo.CreateTask(_product);
        _notification.Show("Your Task Created Successfully");
    }
    private void AssignImageUrl(string imgUrl) => _product.FileUrl = imgUrl;

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TasksFrontEnd.Pages.CreateTask
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputRadioGroup_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
