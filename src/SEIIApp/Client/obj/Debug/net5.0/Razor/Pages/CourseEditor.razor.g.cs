#pragma checksum "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "334b9f2e956b5a668a868b6ffda6883bf168c4c8"
// <auto-generated/>
#pragma warning disable 1591
namespace SEIIApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using SEIIApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using SEIIApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
using SEIIApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
using SEIIApp.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
using SEIIApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/courseeditor/{CourseId:int}")]
    public partial class CourseEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
 if (Course != null)
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3>Course Editor</h3>");
            __builder.AddMarkupContent(1, "<h5>Course Editor</h5>");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
                      Course

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n        ");
                __builder2.AddMarkupContent(7, "<label>Course Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
                                Course.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Course.Name = __value, Course.Name))));
                __builder2.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Course.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<div>&nbsp;</div>\r\n\r\n        ");
                __builder2.AddMarkupContent(14, "<label>Course Description</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
                                Course.Desc

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Course.Desc = __value, Course.Desc))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Course.Desc));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.AddMarkupContent(20, "<div>&nbsp;</div>\r\n\r\n        ");
                __builder2.AddMarkupContent(21, "<label>Course Image (Optional)</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
                                Course.Img

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Course.Img = __value, Course.Img))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Course.Img));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddMarkupContent(27, "<div>&nbsp;</div>\r\n\r\n        ");
                __builder2.AddMarkupContent(28, "<label>Course Text (Optional, ersätzt Description)</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
                                Course.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Course.Text = __value, Course.Text))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Course.Text));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.AddMarkupContent(34, "<div>&nbsp;</div>\r\n\r\n        ");
                __builder2.AddMarkupContent(35, "<label>Video (Optiona)</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
                                Course.VideoURL

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Course.VideoURL = __value, Course.VideoURL))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Course.VideoURL));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.AddMarkupContent(41, "<div>&nbsp;</div>\r\n\r\n        ");
                __builder2.AddMarkupContent(42, "<label>PDF (Optiona)</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
                                Course.PdfURL

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Course.PdfURL = __value, Course.PdfURL))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Course.PdfURL));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.AddMarkupContent(48, "<div>&nbsp;</div>\r\n\r\n        ");
                __builder2.AddMarkupContent(49, "<label>Quiz (Optional)</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
                                Course.QuizId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Course.QuizId = __value, Course.QuizId))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Course.QuizId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(55);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "btn");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
                                  SaveCourseToBackend

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "<img src=\"icons/save_black_24dp.svg\">");
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(60, "<h5>Course in loading (or not found) ...</h5>");
#nullable restore
#line 57 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\CourseEditor.razor"
       


    [Parameter]
    public int CourseId { get; set; }

    public CourseDto Course { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        if (CourseId != 0)
        {
            Course = await CourseService.GetCourseById(CourseId);
        } else
        {
            Course = new CourseDto();
        }
    }


    private void OnSubmit()
    {

    }

    private async void SaveCourseToBackend()
    {
        if(Course.VideoURL != null && Course.VideoURL != "")
        {
            Regex regex = new Regex(@"[^=]+($|$)");
            Course.VideoURL = regex.Match(Course.VideoURL).Value;

        }
        await CourseService.AddOrUpdateCourse(Course);
        NavManager.NavigateTo("/courseeditor");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.CourseBackendAccessService CourseService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
