using System.Security.AccessControl;
using HexDataMovies.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexDataMovies.Client.Services
{
    public interface IServiceMovie
    {
        List<Movie> GetMovies();
        /* Primer método a trabajar: CREAR RECURSO */
        Task<HttpResponseWraper<object>> Post <T>(string url, T send);
        Task<HttpResponseWraper<TResponse>> Post <T,TResponse>(string url, T send);
        Task<HttpResponseWraper<T>> Get <T>(string url);
    }
}