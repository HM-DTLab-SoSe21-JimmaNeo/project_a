// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SEIIApp.Client.Components
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
#line 1 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Components\QuestionDefComponent.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Components\QuestionDefComponent.razor"
using SEIIApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Components\QuestionDefComponent.razor"
using SEIIApp.Client.Pages;

#line default
#line hidden
#nullable disable
    public partial class QuestionDefComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Components\QuestionDefComponent.razor"
       

        [Parameter]
        public QuestionDto QuestionDto { get; set; }


        [CascadingParameter]
        public QuizDefEditor ParentComponent { get; set; }

    private List<AnswerDefComponent> AnswerComponents = new List<AnswerDefComponent>();

    public void AddChild(AnswerDefComponent component)
    {
        AnswerComponents.Add(component);
    }

    public void refresh(Object timer)
    {
        if (timer != null)
        {
            Timer t = (Timer)timer;
            t.Dispose();
        }
        foreach (AnswerDefComponent component in AnswerComponents)
        {

            component.refresh();
            StateHasChanged();
        }
    }


    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        InitiQuestionDefintionDto();
    }

    private void InitiQuestionDefintionDto()
    {
        if (QuestionDto.Answers == null)
            QuestionDto.Answers = Array.Empty<AnswerDto>
    ();

    }

    private void AddAnswer()
    {
        QuestionDto.Answers = QuestionDto.Answers.Concat(new AnswerDto[] {
    new AnswerDto()
    }).ToArray();
    }

    private void RemoveAnswer(AnswerDto answer)
    {
        QuestionDto.Answers = QuestionDto.Answers.Where(a => a != answer).ToArray();
        Timer timer = new Timer(new TimerCallback(refresh));
        timer.Change(1, 0);
    }

    protected override void OnInitialized()
    {

        if (ParentComponent == null)
            throw new Exception("Must be used within MyParentComponent");
        ParentComponent.AddChild(this);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
