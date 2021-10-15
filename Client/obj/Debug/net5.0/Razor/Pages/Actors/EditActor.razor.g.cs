#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/Actors/EditActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9786eb7d6e892622303c4a69d43431465a69f87f"
// <auto-generated/>
#pragma warning disable 1591
namespace HexDataMovies.Client.Pages.Actors
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
#line 2 "/home/saint/Documentos/HexDataMovies/Client/Pages/Actors/EditActor.razor"
using HexDataMovies.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors/edit/{ActorId:int}")]
    public partial class EditActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "jumbotron");
            __builder.AddMarkupContent(4, "<h6>Editar Actor</h6>");
#nullable restore
#line 10 "/home/saint/Documentos/HexDataMovies/Client/Pages/Actors/EditActor.razor"
         if (Actor == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"alert alert-info\" role=\"alert\">Cargando</div>");
#nullable restore
#line 13 "/home/saint/Documentos/HexDataMovies/Client/Pages/Actors/EditActor.razor"

        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HexDataMovies.Client.Pages.Components.FormActorComponent>(6);
            __builder.AddAttribute(7, "Actor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HexDataMovies.Shared.Entity.Actor>(
#nullable restore
#line 17 "/home/saint/Documentos/HexDataMovies/Client/Pages/Actors/EditActor.razor"
                                       Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "/home/saint/Documentos/HexDataMovies/Client/Pages/Actors/EditActor.razor"
                                                             Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 18 "/home/saint/Documentos/HexDataMovies/Client/Pages/Actors/EditActor.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/home/saint/Documentos/HexDataMovies/Client/Pages/Actors/EditActor.razor"
      
    [Parameter] public int ActorId {get;set;}
    Actor Actor = new Actor();
    protected async override Task OnInitializedAsync()
    {
        var httpResponse = await movie.Get<Actor>($"api/actors/{ActorId}");
        if (httpResponse.Error)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/home/saint/Documentos/HexDataMovies/Client/Pages/Actors/EditActor.razor"
                                                                       
            if (httpResponse.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                navigationManager.NavigateTo("actors");
            }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/home/saint/Documentos/HexDataMovies/Client/Pages/Actors/EditActor.razor"
                                              
            else
            {
                await showMessage.ShowErrorMessage(await httpResponse.GetBody());
            }
        }
        else
        {
           Actor = httpResponse.Response;
           Console.WriteLine(Actor.Photo);
        }
        
    }
    private async Task Edit()
    {
        var httpResponse = await movie.Put("api/actors", Actor);
        if (httpResponse.Error)
        {
            await showMessage.ShowErrorMessage(await httpResponse.GetBody());
        }
        else
        {
            navigationManager.NavigateTo("actors");
        }
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
