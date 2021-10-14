#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "933e796e829570194d40665cb061005f5b4626fe"
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
#line 13 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using HexDataMovies.Shared.Configuration;

#line default
#line hidden
#nullable disable
    public partial class GenericList<Titem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
 if (ListResults == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
     if (Loading == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<label class=\"text-muted\">Cargando</label>");
#nullable restore
#line 7 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 10 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
         Loading

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 10 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
                
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
     
}
else if (ListResults.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
     if (NoItems == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<label>No existen registros</label>");
#nullable restore
#line 18 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 21 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
         NoItems

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 21 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
                
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
     
}else{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
     if (ExistsItems != null)
    {
        foreach (var item in ListResults)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 28 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
             ExistsItems(item)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 28 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
                              
        }
    }else{
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 31 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
         ItemsComplete

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 31 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
                      
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/GenericList.razor"
      
    [Parameter] public RenderFragment Loading {get;set;}
    [Parameter] public RenderFragment NoItems {get;set;}
    [Parameter] public RenderFragment<Titem> ExistsItems {get;set;}
    [Parameter] public RenderFragment ItemsComplete {get;set;}
    [Parameter] public List<Titem> ListResults {get;set;}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
