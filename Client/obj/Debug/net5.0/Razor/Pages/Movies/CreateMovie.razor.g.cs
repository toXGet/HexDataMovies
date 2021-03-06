#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "277eb8ac5f25b2d7f9a22fef7fc82e801e0028db"
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
#line 13 "/home/saint/Documentos/HexDataMovies/Client/_Imports.razor"
using HexDataMovies.Shared.Configuration;

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
#nullable restore
#line 7 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
 if (ShowMoviesForm)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HexDataMovies.Client.Pages.Components.FormMovie>(0);
            __builder.AddAttribute(1, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HexDataMovies.Shared.Entity.Movie>(
#nullable restore
#line 9 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
                      Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
                                            Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "NotSelectedFilmGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<HexDataMovies.Shared.Entity.FilmGenre>>(
#nullable restore
#line 9 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
                                                                           NotSelectedFilmGenres

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 10 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<div class=\"alert alert-info\" role=\"alert\">Cargando</div>");
#nullable restore
#line 14 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
      
    private Movie Movie = new Movie();
    private List<FilmGenre> NotSelectedFilmGenres = new List<FilmGenre>();
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/CreateMovie.razor"
                                                                             
    private bool ShowMoviesForm {get;set;} = false;
    protected async override Task OnInitializedAsync()
    {
        var responseHttp = await repositorio.Get<List<FilmGenre>>("api/filmgenres");
        NotSelectedFilmGenres = responseHttp.Response;
        ShowMoviesForm = true;
    }
    
    async Task Create()
    {
        var httpResponse = await repositorio.Post<Movie,int>("api/movies", Movie);
        if (httpResponse.Error)
        {
            var body = await httpResponse.GetBody();
            await showMessage.ShowErrorMessage(body);
            Console.WriteLine(body);
        }
        else
        {
            var MovieId = httpResponse.Response;
            navigationManager.NavigateTo($"/movie/{MovieId}/{Movie.Title.Replace(" ","-")}");
        } 
    }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie repositorio { get; set; }
    }
}
#pragma warning restore 1591
