using System.Collections.Generic;
using HexDataMovies.Shared.Entity;

namespace HexDataMovies.Shared.Configuration
{
    public class VisualizeMovie
    {
        public VisualizeMovie Movie {get;set;}
        public List<FilmGenre> FilmGenres {get;set;}
        public List <Actor> Actors {get;set;}
        public int UserVote {get;set;}
        public double AvgVote {get;set;}
    }
}