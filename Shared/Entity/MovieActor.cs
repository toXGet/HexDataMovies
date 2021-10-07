namespace HexDataMovies.Shared.Entity
{
    public class MovieActor
    {
        public int MovieId {get;set;}
        public int ActorId {get;set;}
        public Actor Actor {get;set;}
        public Movie Movie {get;set;}
        /* Campos adicionales en la relacion débil de MUCHOS a MUCHOS*/
        public int OrderCredits {get;set;}
        public string Character {get;set;}
    }
}