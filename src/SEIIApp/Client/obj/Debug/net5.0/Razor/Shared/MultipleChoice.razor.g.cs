#pragma checksum "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc9af9caa0805b2b2d3e238871b384c840229439"
// <auto-generated/>
#pragma warning disable 1591
namespace SEIIApp.Client.Shared
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
#line 13 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\_Imports.razor"
using SEIIApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class MultipleChoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron border bg-light-grey");
            __builder.AddAttribute(2, "style", "box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19); min-width:90% !important; padding-bottom:10px; text-align: left;");
#nullable restore
#line 4 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
 if (Page < Quiz.Questions.Length)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, 
#nullable restore
#line 6 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
         Quiz.Questions[Page].QuestionText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<div style=\"font-size:24px\">&nbsp;</div>");
#nullable restore
#line 8 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
     foreach (var Answer in Quiz.Questions[Page].Answers)
    {

#line default
#line hidden
#nullable disable
            __Blazor.SEIIApp.Client.Shared.MultipleChoice.TypeInference.CreateCascadingValue_0(__builder, 7, 8, 
#nullable restore
#line 10 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                               this

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.OpenComponent<SEIIApp.Client.Shared.AnswerButton>(10);
                __builder2.AddAttribute(11, "Answer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SEIIApp.Shared.AnswerDto>(
#nullable restore
#line 11 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                                   Answer

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 13 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div style=\"font-size: 24px\">&nbsp;</div>\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-light btn-outline-dark btn-lg");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                                                                    previousPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "disabled", 
#nullable restore
#line 15 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                                                                                            backDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "←");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-light btn-outline-dark btn-lg float-right");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                                                                                nextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "→");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    <br>\r\n    ");
            __builder.OpenElement(24, "small");
            __builder.AddContent(25, 
#nullable restore
#line 18 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
             Page+1

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " / ");
            __builder.AddContent(27, 
#nullable restore
#line 18 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                        Quiz.Questions.Length

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
}
else if (!QuizCompleted)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<h3>\r\n        QUIZ ABSCHLIESSEN?\r\n    </h3>\r\n    ");
            __builder.AddMarkupContent(29, "<div style=\"font-size: 12px\">&nbsp;</div>\r\n    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-danger btn-lg");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                                                    finish

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "JA (KANN NICHT RÜCKGÄNGIG GEMACHT WERDEN)");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.AddMarkupContent(35, "<div style=\"font-size: 12px\">&nbsp;</div>\r\n    ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-dark btn-lg");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                                                  previousPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "NEIN (bring mich zurück!)");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.AddMarkupContent(41, "<div style=\"font-size: 12px\">&nbsp;</div>\r\n    ");
            __builder.OpenElement(42, "small");
            __builder.AddContent(43, 
#nullable restore
#line 30 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
             Page

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(44, " / ");
            __builder.AddContent(45, 
#nullable restore
#line 30 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                      Quiz.Questions.Length

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.AddMarkupContent(47, "<div style=\"font-size: 12px\">&nbsp;</div>");
#nullable restore
#line 32 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "center");
            __builder.OpenComponent<SEIIApp.Client.Shared.QuizResult>(49);
            __builder.AddAttribute(50, "Quiz", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SEIIApp.Shared.QuizDto>(
#nullable restore
#line 37 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                           Quiz

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "OnClickFunction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 37 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                                                  reset

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
 if (!QuizCompleted)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "progress");
            __builder.AddAttribute(54, "style", "background-color: #a94c4c !important;");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "progress-bar");
            __builder.AddAttribute(57, "role", "progressbar");
            __builder.AddAttribute(58, "aria-valuenow", 
#nullable restore
#line 43 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                                                                     Progress

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(59, "aria-valuemin", "0");
            __builder.AddAttribute(60, "aria-valuemax", "100");
            __builder.AddAttribute(61, "style", "width:" + " " + (
#nullable restore
#line 43 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
                                                                                                                                    Progress

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Game\Desktop\SEIITemp\project_a\src\SEIIApp\Client\Shared\MultipleChoice.razor"
       
    [Parameter]
    public QuizDto Quiz { get; set; }

    private List<AnswerButton> children = new List<AnswerButton>();

    public void AddChild(AnswerButton component)
    {
        children.Add(component);
    }

    public bool QuizCompleted = false;

    public int Page = 0;
    public int Progress = 0;

    public bool backDisabled = true;

    private void previousPage()
    {

        if (--Page == 0) backDisabled = true;
        updateProgress();

    }

    private void nextPage()
    {
        if (++Page == 1) backDisabled = false;
        updateProgress();
    }

    private void updateProgress()
    {

        double result = ((double)Page / (double)Quiz.Questions.Length) * 100.0;
        Progress = (int)result;
        Timer timer = new Timer(new TimerCallback(refresh));
        timer.Change(10, 0);
    }

    private void finish()
    {
        QuizCompleted = true;
    }

    public void reset()
    {
        foreach (QuestionDto question in Quiz.Questions)
        {
            foreach (AnswerDto answer in question.Answers)
            {
                answer.IsSelected = false;
            }
        }
        Page = 0;
        Progress = 0;
        QuizCompleted = false;
        Timer timer = new Timer(new TimerCallback(refresh));
        timer.Change(1, 0);
    }

    public void refresh(Object timer)
    {
        if (timer != null)
        {
            Timer t = (Timer)timer;

        }
        foreach (AnswerButton button in children)
        {
            button.refresh();
        }
    }
    protected override void OnInitialized()
    {
        updateProgress();
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SEIIApp.Client.Shared.MultipleChoice
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
