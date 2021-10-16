#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54dff999b3f48f921363215bd43a47b596db6eb5"
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
    public partial class MovieList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "display: flex; flex-wrap: wrap; align-items: center;");
            __Blazor.HexDataMovies.Client.Pages.Components.MovieList.TypeInference.CreateGenericList_0(__builder, 2, 3, 
#nullable restore
#line 6 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieList.razor"
                          Movies

#line default
#line hidden
#nullable disable
            , 4, (movie) => (__builder2) => {
                __builder2.OpenComponent<HexDataMovies.Client.Pages.Components.MovieInd>(5);
                __builder2.AddAttribute(6, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HexDataMovies.Shared.Entity.Movie>(
#nullable restore
#line 8 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieList.razor"
                             movie

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "DeleteMovie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<HexDataMovies.Shared.Entity.Movie>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<HexDataMovies.Shared.Entity.Movie>(this, 
#nullable restore
#line 8 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieList.razor"
                                                 DeleteMovie

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/MovieList.razor"
       
    [Parameter] public List<Movie>Movies { get; set; }
 
    async Task DeleteMovie(Movie movie)
    {
        var confirmar = await js.InvokeAsync<bool>("confirm", $"¿Desea borrar la película '{movie.Title}'?");
        if (confirmar)
        {
            var responseHttp = await movie_i.Delete($"api/movies/{movie.Id}");
            if (responseHttp.Error)
            {
                await showMessage.ShowErrorMessage(await responseHttp.GetBody());
            }else{
                Movies.Remove(movie);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie_i { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.HexDataMovies.Client.Pages.Components.MovieList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Titem> __arg1)
        {
        __builder.OpenComponent<global::HexDataMovies.Client.Pages.Components.GenericList<Titem>>(seq);
        __builder.AddAttribute(__seq0, "Listado", __arg0);
        __builder.AddAttribute(__seq1, "HayRegistros", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591