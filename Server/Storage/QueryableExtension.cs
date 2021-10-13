using System.Linq;
using HexDataMovies.Shared.Configuration;

namespace HexDataMovies.Server.Storage
{
    public static class QueryableExtension
    {
       public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, Pagination pagination)
       {
            return queryable.Skip((pagination.Pagina -1)* pagination.CantidadRegistros).
            Take(pagination.CantidadRegistros);
       }
    }
}