#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5cde959662dd92972c6d7ed8174806b152e6731"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}/{MovieName}")]
    public partial class ShowMoviePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
 if (model == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Cargando...");
#nullable restore
#line 10 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                            
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, 
#nullable restore
#line 14 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
         model.Movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " (");
            __builder.AddContent(4, 
#nullable restore
#line 14 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                             model.Movie.Premier.Value.ToString("yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, ")");
            __builder.CloseElement();
#nullable restore
#line 15 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
    for (int i = 0; i < model.FilmGenres.Count; i++)
    {
        if (i < model.FilmGenres.Count - 1)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 19 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
             linkCategory(model.FilmGenres[i])

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, ", ");
#nullable restore
#line 19 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                             
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, 
#nullable restore
#line 23 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
             linkCategory(model.FilmGenres[i])

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 23 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                              
        }
    }
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, " |  ");
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, 
#nullable restore
#line 26 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                            model.Movie.Premier.Value.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(12, " | Promedio: ");
            __builder.AddContent(13, 
#nullable restore
#line 27 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                model.AvgVote.ToString("0.#")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, "/5 | Tu voto: ");
            __builder.AddContent(15, 
#nullable restore
#line 27 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                                                           model.UserVote.ToString("0.#")

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "display: flex;");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "style", "display: inline-block; margin-right: 5px;");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 29 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                                           model.Movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "style", "width: 225px; height: 315px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n        ");
            __builder.OpenElement(24, "iframe");
            __builder.AddAttribute(25, "width", "560");
            __builder.AddAttribute(26, "height", "315");
            __builder.AddAttribute(27, "src", "https://www.youtube.com/embed/" + (
#nullable restore
#line 30 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                                             model.Movie.Trailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "frameborder", "0");
            __builder.AddAttribute(29, "allow", "accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(30, "allowfullscreen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(34, "<h3>Actores</h3>\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "style", "display: flex; flex-direction: column");
#nullable restore
#line 35 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
             foreach (var actor in model.Actors)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "margin-bottom: 2px;");
            __builder.OpenElement(39, "img");
            __builder.AddAttribute(40, "style", "width: 50px;");
            __builder.AddAttribute(41, "src", 
#nullable restore
#line 38 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                    actor.Photo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.OpenElement(43, "span");
            __builder.AddAttribute(44, "style", "display:inline-block;width: 200px;");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "href", "/actor/" + (
#nullable restore
#line 39 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                                                      actor.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 39 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                                                                actor.Name.Replace(" ", "-")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, 
#nullable restore
#line 39 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                                                                                               actor.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                    ");
            __builder.AddMarkupContent(49, "<span style=\"display:inline-block; width: 45px;\">...</span>\n                    ");
            __builder.OpenElement(50, "span");
            __builder.AddContent(51, 
#nullable restore
#line 41 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                           actor.Character

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
      
    [Parameter] public int MovieId {get;set;}
    [Parameter] public string MovieName {get;set;}
    private ShowMovie model;
    private RenderFragment<FilmGenre> linkCategory = (category) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(52, "a");
            __builder2.AddAttribute(53, "href", "movies/search?categoryId=" + (
#nullable restore
#line 53 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                                                                      category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(54, 
#nullable restore
#line 53 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                                                                                    category.Name

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 53 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                                                                                                     ;
    protected async override Task OnInitializedAsync()
    {
        var responseHttp = await repositorio.Get<ShowMovie>($"api/movies/{MovieId}");
        if (responseHttp.Error)
        {
            if (responseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                navigationManager.NavigateTo("");
            }
            else
            {
                var mensajeError = await responseHttp.GetBody();
                await showMessage.ShowErrorMessage(mensajeError);
            }
        }
        else
        {
            model = responseHttp.Response;
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