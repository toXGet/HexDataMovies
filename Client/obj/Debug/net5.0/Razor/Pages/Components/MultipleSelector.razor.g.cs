#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a6fab788d0f98d9d537f66642ac2545bef84a2"
// <auto-generated/>
#pragma warning disable 1591
namespace HexDataMovies.Client.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using HexDataMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using HexDataMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using HexDataMovies.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using HexDataMovies.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
using HexDataMovies.Client.Model;

#line default
#line hidden
#nullable disable
    public partial class MultipleSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style type=""text/css"">
    .selector-multiple {
        display: flex;
    }    

    .selectable-ul {
        height: 200px;
        width: 170px;
        overflow-y: auto;
        list-style-type: none;
        padding: 0%;
        border-radius: 3px;
        border: 1px solid #fff;
    }

    .selectable-ul li {
        cursor: pointer;
        border-bottom: 1px #eee solid;
        padding: 2px 10px;
        font-size: 14px;
    }

    .selectable-ul li:hover {
        background-color: #969992;
    }

    .selector-multiple-botones {
        display: flex;
        border-radius: 10px;
        flex-direction: column;
        justify-content: center;
        padding: 5px;
    }

    .selector-multiple-botones button {
        margin: 5px;
    }

    .selector-multiple-botones button:hover {
        background-color: #969992;
    }
</style>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "selector-multiple");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "selectable-ul");
#nullable restore
#line 48 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
             foreach (var item in NotSelected)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
                                ()=>Seleccionar(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, 
#nullable restore
#line 50 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
                                                         item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 51 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "selector-multiple-botones");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
                                            SelectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, 
#nullable restore
#line 55 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
                                                        selectAllText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
                                            UnSelectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, 
#nullable restore
#line 56 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
                                                          removeAllText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n        ");
            __builder.OpenElement(23, "ul");
            __builder.AddAttribute(24, "class", "selectable-ul");
#nullable restore
#line 60 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
             foreach (var item in Selected)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
                                ()=>Deseleccionar(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, 
#nullable restore
#line 62 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
                                                           item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 63 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
      
    private string removeAllText = "<<";
    private string selectAllText = ">>";
    [Parameter] public List<MultipleSelectorModel> NotSelected {get;set;} = new List<MultipleSelectorModel>();
    [Parameter] public List<MultipleSelectorModel> Selected {get;set;} = new List<MultipleSelectorModel>();

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
                                                                            
    private void Seleccionar(MultipleSelectorModel item)
    {
        NotSelected.Remove(item);
        Selected.Add(item);
    }    
    private void Deseleccionar(MultipleSelectorModel item)
    {
        Selected.Remove(item);
        NotSelected.Add(item);    
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MultipleSelector.razor"
                                                                  
    private void SelectAll()
    {
        Selected.AddRange(NotSelected);
        NotSelected.Clear();
    }
     private void UnSelectAll()
    {
        NotSelected.AddRange(Selected);
        Selected.Clear();
    }    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591