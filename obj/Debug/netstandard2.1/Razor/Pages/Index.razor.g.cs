#pragma checksum "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdf41cd0d1efa34865ab49f2d12506d3884f8197"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "flex flex-row w-screen h-full");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "para-form");
            __builder.AddAttribute(5, "class", "w-1/2 flex flex-col");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<div class=""mt-20"">
            <h1 class=""text-center text-3xl text-zinc-900 text-cyan-400 font-black"">Word Frequency</h1>
            <h3 class=""mt-0 font-serif text-center text-xl text-zinc-600 font-light"">See how many times words occur in a body of text</h3>
        </div>
        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "class", "mt-20 flex flex-col w-2/3 m-auto justify-items-end");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "id", "form-and-character-count");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<label class=\"font-serif text-zinc-700 text-semibold\">Your text</label>\r\n                ");
                __builder2.OpenElement(16, "textarea");
                __builder2.AddAttribute(17, "class", "shadow-inner w-full rounded border-2 resize-none bg-zinc-100");
                __builder2.AddAttribute(18, "rows", "5");
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
                                                                                                                    updateCurrentText

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "placeholder", "The brown cow has speckled spots...");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenElement(22, "p");
                __builder2.AddAttribute(23, "id", "character-count");
                __builder2.AddAttribute(24, "style", 
#nullable restore
#line 16 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
                                                characterCountValiditiy()

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 16 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
__builder2.AddContent(25, characterCount);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(26, " / 2048 characters max");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "id", "submit-btn");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
                                           SubmitText

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "class", "flex justify-end");
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenElement(34, "button");
                __builder2.AddAttribute(35, "disabled", 
#nullable restore
#line 19 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
                                   isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(36, "class", "p-2 w-1/3 font-mono drop-shadow-lg bg-green-400 text-white disabled:bg-zinc-500 disabled:text-zinc-100");
                __builder2.AddMarkupContent(37, "\r\n                    Translate\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "id", "translator-table");
            __builder.AddAttribute(44, "class", "w-1/2 bg-cyan-500 h-screen flex flex-column items-center shadow-inner");
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 27 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
         if (isTranslated)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "            ");
            __builder.OpenComponent<WordFrequency.Components.TranslatorTable>(47);
            __builder.AddAttribute(48, "isTranslated", 
#nullable restore
#line 29 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
                                            isTranslated

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(49, "textInput", "I scream, you scream, we all scream for ice cream.");
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 30 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "            ");
            __builder.AddMarkupContent(52, "<h2 class=\"m-auto w-1/2 text-2xl font-mono text-white flex flex-column items-center\">Let\'s Translate Some Words!</h2>\r\n");
#nullable restore
#line 34 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.AddMarkupContent(55, "<footer class=\"w-1/2 absolute bg-zinc-200 bottom-0\">\r\n        <p class=\"indent-5 text-cyan-700\">Word Frequency. 2022</p>\r\n    </footer>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
       
    private String CurrentText;
    private String prevText;
    protected bool isChanged { get; set; }
    protected bool isDisabled { get; set; }
    private bool isTranslated { get; set; }
    private int? characterCount { get; set; }

    private void SubmitText()
    {
        if(!isTranslated) isTranslated = true;
        Console.WriteLine("isTranslated = " + isTranslated);
    }

    private void updateCurrentText(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {
        CurrentText = (string)args.Value;

        if (CurrentText != prevText)
        {
            isDisabled = false;
        }
        else
        {
            isDisabled = true;
        }

        Console.WriteLine("isChanged = " + isChanged);
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


  
    protected override void OnInitialized()
    {
        CurrentText = "";
        prevText = CurrentText;
        characterCount = 0;
        isTranslated = false;
        isDisabled = true;

        Console.WriteLine("isChanged = " + isChanged);
        Console.WriteLine("isTranslated = " + isTranslated);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
