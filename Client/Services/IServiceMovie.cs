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
    }
}