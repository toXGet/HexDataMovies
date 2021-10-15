using System.Collections.Generic;
using HexDataMovies.Shared.Entity;

namespace HexDataMovies.Shared.Configuration
{
    public class ShowMovie
    {
        public Movie Movie {get;set;}
        public List<FilmGenre> FilmGenres {get;set;}
        public List <Actor> Actors {get;set;}
        public int UserVote {get;set;}
        public double AvgVote {get;set;}
    }
}