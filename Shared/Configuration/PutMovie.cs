using System.Collections.Generic;
using HexDataMovies.Shared.Entity;

namespace HexDataMovies.Shared.Configuration
{
    public class PutMovie
    {
        public Movie Movie {get;set;}
        public List <Actor> Actors {get;set;}
        public List <FilmGenre> SelectedFilmGenres {get;set;}
        public List <FilmGenre> NotSelectedFilmGenres {get;set;}
    }
}