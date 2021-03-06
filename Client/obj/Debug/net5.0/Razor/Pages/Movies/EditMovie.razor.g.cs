#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ff6fcaee68b46b35ce153fb5abf6645015984a5"
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
#nullable restore
#line 3 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
using HexDataMovies.Shared.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/edit/{MovieId:int}")]
    public partial class EditMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Pelicula</h3>");
#nullable restore
#line 11 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
 if (Movie == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"alert alert-info\" role=\"alert\">Cargando</div>");
#nullable restore
#line 14 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HexDataMovies.Client.Pages.Components.FormMovie>(2);
            __builder.AddAttribute(3, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HexDataMovies.Shared.Entity.Movie>(
#nullable restore
#line 17 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                      Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                                            Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ActoresSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<HexDataMovies.Shared.Entity.Actor>>(
#nullable restore
#line 18 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                              ActoresSeleccionados

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "NotSelectedFilmGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<HexDataMovies.Shared.Entity.FilmGenre>>(
#nullable restore
#line 19 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                               NotSelectedFilmGenres

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "SelectedFilmGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<HexDataMovies.Shared.Entity.FilmGenre>>(
#nullable restore
#line 20 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                            SelectedFilmGenres

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 21 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
      
    [Parameter] public int MovieId {get;set;}
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/EditMovie.razor"
                                    
    Movie Movie;
    private List<FilmGenre> SelectedFilmGenres = new List<FilmGenre>();
    private List<FilmGenre> NotSelectedFilmGenres = new List<FilmGenre>();
    private List<Actor> ActoresSeleccionados { get; set; }
    protected async override Task OnInitializedAsync()
    {
        var httpResponse = await movie_i.Get<PutMovie>($"api/movies/edit/{MovieId}");
 
        if (httpResponse.Error)
        {
            if (httpResponse.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                navigationManager.NavigateTo("");
            }
            else
            {
                await showMessage.ShowErrorMessage(await httpResponse.GetBody());
            }
        }
        else
        {
            var model = httpResponse.Response;
            ActoresSeleccionados = model.Actors;
            SelectedFilmGenres = model.NotSelectedFilmGenres;
            NotSelectedFilmGenres = model.SelectedFilmGenres;
            Movie = model.Movie;
        }
    }

    private async Task Edit()
    {
        var httpResponse = await movie_i.Put("api/movies", Movie);
        if (httpResponse.Error)
        {
            await showMessage.ShowErrorMessage(await httpResponse.GetBody());
        }
        else
        {
            navigationManager.NavigateTo($"movie/{MovieId}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie_i { get; set; }
    }
}
#pragma warning restore 1591
