namespace HexDataMovies.Shared.Entity
{
    public class CategoryMovie
    {
        public int MovieId {get;set;}
        public int FilmGenreId {get;set;}
        public FilmGenre FilmGenre {get;set;}
        public Movie Movie {get;set;}
    }
}