#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec6f8b17e29b1788592a0bc06b6a9e047e16f1c"
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
    public partial class MovieComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "href", 
#nullable restore
#line 2 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieComponent.razor"
              urlMovie

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", 
#nullable restore
#line 3 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieComponent.razor"
                   Movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "alt", "Poster");
            __builder.AddAttribute(7, "width", "225px");
            __builder.AddAttribute(8, "height", "300px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n    ");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "style", "max-width: 225px; height: 44px; font-size: 15px; font-weight: bold;");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", 
#nullable restore
#line 6 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieComponent.razor"
                  urlMovie

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, 
#nullable restore
#line 6 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieComponent.razor"
                             Movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddMarkupContent(17, "<a class=\"btn btn-info\">Editar</a>\n        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-danger");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieComponent.razor"
                                                                 ()=>DeleteMovie.InvokeAsync(Movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "\n            Eliminar\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieComponent.razor"
      
    [Parameter] public Movie Movie {get;set;}
    [Parameter] public EventCallback<Movie> DeleteMovie {get;set;}
    private string urlMovie = string.Empty;
    protected override void OnInitialized()
    {
        urlMovie = $"movies/";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
