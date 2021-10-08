// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
using HexDataMovies.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/create")]
    public partial class CreateMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
      
    private Movie Movie = new Movie();
    private List<FilmGenre> NotSelectedFilmGenres = new List<FilmGenre>();
    
    protected override void OnInitialized()
    {
        NotSelectedFilmGenres = new List<FilmGenre>()
            {
                new FilmGenre(){Id = 1, Name = "Comedia"},
                new FilmGenre(){Id = 2, Name = "Ciencia Ficción"},
                new FilmGenre(){Id = 3, Name = "Documentales"},
                new FilmGenre(){Id = 4, Name = "Acción"},
                new FilmGenre(){Id = 5, Name = "Drama"},
                new FilmGenre(){Id = 6, Name = "Terror"},
                new FilmGenre(){Id = 7, Name = "Animación"}
            };
    }
    
    void Create()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
                                                                                               
        Console.WriteLine(navigationManager.Uri);
        navigationManager.NavigateTo("movie");
        Console.WriteLine($"Película: {Movie.Title}");
        Console.WriteLine($"Premier: {Movie.Premier}");
        Console.WriteLine($"Está en Cartelera: {Movie.EnCartelera}");
        Console.WriteLine($"Poster: {Movie.Poster}");
        Console.WriteLine($"Sinopsis: {Movie.Sinopsis}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
