// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WordFrequency.Components
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
#line 1 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
using WordFrequency.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
using WordFrequency.Components;

#line default
#line hidden
#nullable disable
    public partial class TranslatorTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
       

    [Parameter]
    public String textInput { get; set; }

    List<Word> words = new List<Word>();
    int totalWords;
    int totalCount;

    public int getTotalCount()
    {

        for (int i = 0; i <= words.Count; i++)
        {
            int curr = words[i].Frequency;

            totalCount += curr;

        }

        return totalCount;

    }
    public int getTotalWords() => totalWords = words.Count;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        /*@ dummy data @*/
        /*words.Add(new Word("all", 1));
        words.Add(new Word("cream", 1));
        words.Add(new Word("for", 1));
        words.Add(new Word("I", 1));
        words.Add(new Word("ice", 1));
        words.Add(new Word("scream", 3));
        words.Add(new Word("we", 1));
        words.Add(new Word("you", 1));*/

        getTotalCount();
        getTotalWords();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
