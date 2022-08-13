// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WordFrequency.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using WordFrequency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using WordFrequency.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
using WordFrequency.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
       
    protected TranslatorTable translatorTable;
    private string prevText;
    private string CurrentText;
    string alertMessage = "";
    private int? characterCount { get; set; }
    protected bool isDisabled { get; set; }
    public int Width { get; set; }


    public async void translateText()
    {
        if(CurrentText.Trim() == "") {
            alertMessage = "Textbox is empty. Please enter some words";

            await JS.InvokeVoidAsync("Alert", alertMessage);
        } else {
            translatorTable.resetTable();
            translatorTable.convertInputToWordList();
            initState();
        }
       
    }

    private void updateInputText(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {
        CurrentText = (string)args.Value;

        if(CurrentText != prevText) isDisabled = false;
        else isDisabled = true;
        characterCount = CurrentText.Length;
    }

    private string characterCountValiditiy()
    {

        if (characterCount == 0)
        {
            return "color: gray";
        }
        else if (characterCount > 2048)
        {
            return "color: red";
        }
        else
        {
            return "";
        }

    }

    private string textAreaValidity()
    {
        if (CurrentText == "") return "textarea-error";
        else return "textarea-default";
    }

    private void initState()
    {
        isDisabled = true;
        CurrentText = "";
        prevText = CurrentText;
        characterCount = 0;

        Console.Write("CurrentText = " + CurrentText);
        StateHasChanged();
    }

    protected override void OnInitialized()
    {
        CurrentText = "";
        prevText = CurrentText;
        characterCount = 0;
        isDisabled = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
