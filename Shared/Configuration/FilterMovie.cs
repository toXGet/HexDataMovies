using System.Collections.Generic;
using HexDataMovies.Shared.Entity;

namespace HexDataMovies.Shared.Configuration
{
    public class FilterMovie
    {
        public List<Movie> PeliculasEnCartelera {get;set;}
        public List<Movie> ProximosEstrenos {get;set;}
    }
}