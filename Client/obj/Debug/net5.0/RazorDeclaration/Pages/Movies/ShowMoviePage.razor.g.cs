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
            __builder2.OpenElement(0, "a");
            __builder2.AddAttribute(1, "href", "movies/search?categoryId=" + (
#nullable restore
#line 53 "/home/saint/Documentos/HexDataMovies/Client/Pages/Movies/ShowMoviePage.razor"
                                                                                                      category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(2, 
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
