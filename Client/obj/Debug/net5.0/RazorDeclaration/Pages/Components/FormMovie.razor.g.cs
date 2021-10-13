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
#line 1 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
using HexDataMovies.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
using HexDataMovies.Client.Model;

#line default
#line hidden
#nullable disable
    public partial class FormMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
      
    [Parameter] public Movie Movie {get; set;}

    [Parameter] public EventCallback OnValidSubmit {get; set;}

    [Parameter] public List<FilmGenre> SelectedFilmGenres {get;set;} = new List<FilmGenre>();
    [Parameter] public List<FilmGenre> NotSelectedFilmGenres {get;set;} = new List<FilmGenre>(); 
    
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                    
    [Parameter] public List<Actor> ActoresSeleccionados { get; set; } = new List<Actor>();

    private List<MultipleSelectorModel> Selected {get;set;} = new List<MultipleSelectorModel>();
    private List<MultipleSelectorModel> NotSelected {get;set;} = new List<MultipleSelectorModel>();    
    
    private string posterTemporal;

    private void ImageSelected(string imageB64)
    {
        Movie.Poster = imageB64;
    }

    protected override void OnInitialized()
    {
        Selected = SelectedFilmGenres.Select(x => new MultipleSelectorModel(x.Id.ToString(), x.Name)).ToList();
        NotSelected = NotSelectedFilmGenres.Select(x => new MultipleSelectorModel(x.Id.ToString(), x.Name)).ToList();
        if (!string.IsNullOrWhiteSpace(Movie.Poster))
        {
            posterTemporal = Movie.Poster;
            Movie.Poster = null;
        }
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                    
    private async Task<IEnumerable<Actor>> BuscarActores(string searchText)
    {
        return new List<Actor>(){
            new Actor(){Id=1, Name="Yaneth Mejía", Photo="https://pbs.twimg.com/profile_images/1079060744891785216/dAsFSbHH_400x400.jpg"},
            new Actor(){Id=2, Name="Carolina Marquez", Photo="https://archivo.autonoma.edu.co/sites/default/files/styles/medium/public/carolina-marquez-narvaez.jpg?itok=CcL43PAR"},
            new Actor(){Id=3, Name="Juan Esteban", Photo="https://cdn1.vectorstock.com/i/1000x1000/29/65/cinema-award-best-actor-flat-style-vector-13602965.jpg"}
        };
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                          
    private async Task OnDataAnnotationsValidated(){
        Movie.CategoriesMovie = Selected.Select(x => new CategoryMovie{FilmGenreId = int.Parse(x.Key)}).ToList();
        Movie.MoviesActor = ActoresSeleccionados.Select(x => new MovieActor{ActorId = x.Id, Character = x.Character}).ToList();
        if (!string.IsNullOrWhiteSpace(Movie.Poster))
        {
            posterTemporal = null;
        }
        await OnValidSubmit.InvokeAsync(null);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
