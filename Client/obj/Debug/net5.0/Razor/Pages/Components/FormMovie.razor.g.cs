#pragma checksum "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "351cab211f0f5d23e42e81ea72c03cceed1dacf6"
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
#nullable restore
#line 1 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
using HexDataMovies.Client.Model;

#line default
#line hidden
#nullable disable
    public partial class FormMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                 Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                       OnDataAnnotationsValidated

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "jumbotron");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "placeholder", "Título de la Película");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                                      Movie.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Title = __value, Movie.Title))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n                        ");
                __Blazor.HexDataMovies.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#nullable restore
#line 13 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                  ()=>Movie.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n                    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col col-sm-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(28);
                __builder2.AddAttribute(29, "id", "en_cartelera");
                __builder2.AddAttribute(30, "class", "form-check-input");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                                                                Movie.EnCartelera

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.EnCartelera = __value, Movie.EnCartelera))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Movie.EnCartelera));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\n                        ");
                __builder2.AddMarkupContent(35, "<label for=\"en_cartelera\" class=\"form-check-label\">Está en Cartelera?</label>\n                        ");
                __Blazor.HexDataMovies.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 19 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                  ()=>Movie.EnCartelera

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "row");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "placeholder", "Trailer de la Película");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                                      Movie.Trailer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Trailer = __value, Movie.Trailer))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Trailer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n                        ");
                __Blazor.HexDataMovies.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 28 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                  ()=>Movie.Trailer

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __Blazor.HexDataMovies.Client.Pages.Components.FormMovie.TypeInference.CreateInputDate_3(__builder2, 59, 60, "form-control", 61, 
#nullable restore
#line 33 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                                          Movie.Premier

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Premier = __value, Movie.Premier)), 63, () => Movie.Premier);
                __builder2.AddMarkupContent(64, "\n                            ");
                __Blazor.HexDataMovies.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_4(__builder2, 65, 66, 
#nullable restore
#line 34 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                      ()=>Movie.Premier

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n            ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(70);
                __builder2.AddAttribute(71, "class", "form-control");
                __builder2.AddAttribute(72, "placeholder", "Sinópsis");
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                                  Movie.Sinopsis

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Sinopsis = __value, Movie.Sinopsis))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Sinopsis));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\n                ");
                __Blazor.HexDataMovies.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_5(__builder2, 77, 78, 
#nullable restore
#line 42 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                          ()=>Movie.Sinopsis

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\n            ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "row");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "col");
                __builder2.AddMarkupContent(86, "<label>Seleccione las Categorías</label>\n                        ");
                __builder2.OpenElement(87, "div");
                __builder2.OpenComponent<HexDataMovies.Client.Pages.Components.MultipleSelector>(88);
                __builder2.AddAttribute(89, "Selected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<HexDataMovies.Client.Model.MultipleSelectorModel>>(
#nullable restore
#line 50 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                        Selected

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "NotSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<HexDataMovies.Client.Model.MultipleSelectorModel>>(
#nullable restore
#line 50 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                                               NotSelected

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "col");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-group");
                __builder2.OpenComponent<HexDataMovies.Client.Pages.Components.ImageComponent>(96);
                __builder2.AddAttribute(97, "Label", "");
                __builder2.AddAttribute(98, "ImageSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 56 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                                    ImageSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(99, "ImageURL", "");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\n            ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-group");
                __builder2.AddMarkupContent(103, "<label>Actores:</label>\n                ");
                __builder2.OpenElement(104, "div");
                __Blazor.HexDataMovies.Client.Pages.Components.FormMovie.TypeInference.CreateSelectorMultipleTypeaHead_6(__builder2, 105, 106, 
#nullable restore
#line 65 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                                             BuscarActores

#line default
#line hidden
#nullable disable
                , 107, 
#nullable restore
#line 65 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                                                                                    ActoresSeleccionados

#line default
#line hidden
#nullable disable
                , 108, (actor) => (__builder3) => {
                    __builder3.AddContent(109, 
#nullable restore
#line 66 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                         actor.Name

#line default
#line hidden
#nullable disable
                    );
                }
                , 110, (actor) => (__builder3) => {
                    __builder3.OpenElement(111, "img");
                    __builder3.AddAttribute(112, "style", "width: 30px");
                    __builder3.AddAttribute(113, "src", 
#nullable restore
#line 72 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                                           actor.Photo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\n                            ");
                    __builder3.AddContent(115, 
#nullable restore
#line 73 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                             actor.Name

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\n            ");
                __builder2.AddMarkupContent(117, "<button type=\"submit\" class=\"btn btn-success\">Aceptar</button>\n            ");
                __builder2.AddMarkupContent(118, "<button type=\"submit\" class=\"btn btn-danger\">Cancelar</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
      
    [Parameter] public Movie Movie {get; set;}

    [Parameter] public EventCallback OnValidSubmit {get; set;}

    [Parameter] public List<FilmGenre> SelectedFilmGenres {get;set;} = new List<FilmGenre>();
    [Parameter] public List<FilmGenre> NotSelectedFilmGenres {get;set;} = new List<FilmGenre>(); 
    
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                    
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
#line 115 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                                    
    private async Task<IEnumerable<Actor>> BuscarActores(string searchText)
    {
        var responseHttp = await movie_i.Get<List<Actor>>($"api/actors/search/{searchText}");
        return responseHttp.Response;
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "/home/saint/Documentos/HexDataMovies/Client/Pages/Components/FormMovie.razor"
                          
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie_i { get; set; }
    }
}
namespace __Blazor.HexDataMovies.Client.Pages.Components.FormMovie
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateSelectorMultipleTypeaHead_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<T>>> __arg0, int __seq1, global::System.Collections.Generic.List<T> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg3)
        {
        __builder.OpenComponent<global::HexDataMovies.Client.Pages.Components.SelectorMultipleTypeaHead<T>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "ElementosSeleccionados", __arg1);
        __builder.AddAttribute(__seq2, "MyListTemplate", __arg2);
        __builder.AddAttribute(__seq3, "MyResultTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
