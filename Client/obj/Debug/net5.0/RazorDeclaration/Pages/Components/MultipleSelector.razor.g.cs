// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
