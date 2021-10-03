#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c83e9271a2c9f8cd7fd65ed42948744ebddb247"
// <auto-generated/>
#pragma warning disable 1591
namespace HexDataMovies.Client.Pages.Movies
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
#line 2 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
using HexDataMovies.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/edit/{MovieId:int}")]
    public partial class EditMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<HexDataMovies.Client.Pages.Components.FormMovie>(0);
            __builder.AddAttribute(1, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HexDataMovies.Shared.Entity.Movie>(
#nullable restore
#line 5 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                  Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                                        Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
      
    [Parameter] public int MovieId {get;set;}
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                                    
    private Movie Movie;
    
    void Edit(){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                                                 
        Console.WriteLine($"Pelicula: {Movie.Title}");
        Console.WriteLine($"Premier: {Movie.Premier}");
        Console.WriteLine($"Esta en cartelera: {Movie.EnCartelera}");
        Console.WriteLine($"Poster: {Movie.Poster}");
        Console.WriteLine($"Sinopsis: {Movie.Sinopsis}");
    }

    protected override void OnInitialized(){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                                                                    
        Movie = new Movie()
        {
            Title = "La Princesa Mononoke",
            EnCartelera = true,
            Sinopsis = "Sinopsis...",
            Trailer = "Trailer"
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
