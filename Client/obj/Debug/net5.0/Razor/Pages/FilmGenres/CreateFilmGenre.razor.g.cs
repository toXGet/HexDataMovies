#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/FilmGenres/CreateFilmGenre.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f24c5cdbe1ea19381940a136b406623339f0a6"
// <auto-generated/>
#pragma warning disable 1591
namespace HexDataMovies.Client.Pages.FilmGenres
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
#line 2 "/home/saint/Documentos/HexDataMovies/Client/Pages/FilmGenres/CreateFilmGenre.razor"
using HexDataMovies.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/filmgenres/create")]
    public partial class CreateFilmGenre : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenComponent<HexDataMovies.Client.Pages.Components.FormFilmGenreComponent>(2);
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "/home/saint/Documentos/HexDataMovies/Client/Pages/FilmGenres/CreateFilmGenre.razor"
                                           Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "FilmGenre", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HexDataMovies.Shared.Entity.FilmGenre>(
#nullable restore
#line 5 "/home/saint/Documentos/HexDataMovies/Client/Pages/FilmGenres/CreateFilmGenre.razor"
                                                              FilmGenre

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/home/saint/Documentos/HexDataMovies/Client/Pages/FilmGenres/CreateFilmGenre.razor"
      
    private FilmGenre FilmGenre = new FilmGenre();
    private void Create()
    {
        Console.WriteLine($"Nombre de la categoría de películas {FilmGenre.Name}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
