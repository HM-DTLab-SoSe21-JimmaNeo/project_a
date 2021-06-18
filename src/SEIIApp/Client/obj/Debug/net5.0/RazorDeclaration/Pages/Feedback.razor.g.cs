// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 12 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using SEIIApp.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\Feedback.razor"
using SEIIApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/feedback")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/feedback/{CourseId:int}")]
    public partial class Feedback : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Pages\Feedback.razor"
       
    [Parameter]
    public int? CourseId { get; set; }


    public FeedbackDto message = new FeedbackDto();

    private EditContext context { get; set; }

    async Task sendFeedback()
    {
        if (context.Validate())
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
            if (confirmed)
            {
                //TODO: Email verschicken
                navManager.NavigateTo(CourseId != null ? "/Course/" + CourseId : "/");

            }
        }
    }

    private void OnSubmit(EditContext context)
    {
    }

    private CourseDto Course;

    protected override async Task OnParametersSetAsync()
    {

        context = new EditContext(message);
        if (CourseId != null)
        {
            Course = await CourseService.GetCourseById((int)CourseId);

        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.CourseBackendAccessService CourseService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
    }
}
#pragma warning restore 1591
