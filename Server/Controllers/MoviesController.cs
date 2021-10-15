using HexDataMovies.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HexDataMovies.Server.Storage;
using HexDataMovies.Shared.Configuration;
using AutoMapper;

namespace HexDataMovies.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MoviesController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorage FilesStorage;
        /* Carpeta que se crea para el almacenamiento local de multimedia */
        private readonly string carpeta = "movies";
        private readonly IMapper Mapper;

        public MoviesController(ApplicationDbContext context, IFilesStorage filesStorage, IMapper mapper)
        {
            this.context = context;
            this.FilesStorage = filesStorage;
            this.Mapper = mapper;
        }
        /* Almacena la Información de la película */

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var movie_poster = Convert.FromBase64String(movie.Poster);
                movie.Poster = await FilesStorage.SaveFile(movie_poster,"jpg", carpeta);
            }
            /* Añadido del jueves para organizar los actores */
            if (movie.MoviesActor != null)
            {
                for (int i = 0; i < movie.MoviesActor.Count; i++)
                {
                    movie.MoviesActor[i].OrderCredits = i + 1;
                }
            }

            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }

        /* Listar peliculas por filtro de Películas en Cartelera y Próximos estrenos*/
        [HttpGet]
        public async Task<ActionResult<FilterMovie>>Get()
        {
            /* Paginación => datatable o cantidad de peliculas => cards */
            var limit = 10;
            var peliculasEnCartelera = await context.Movies.Where(x=> x.EnCartelera).Take(limit).OrderByDescending(x=>x.Premier).ToListAsync();
            /* Los próximos lanzamientos deben ser mayores a la fecha actual */
            var currentDate = DateTime.Today;
            var proximosEstrenos = await context.Movies.Where(x => x.Premier > currentDate).OrderBy(x=>x.Premier).Take(limit).ToListAsync();
            var response = new FilterMovie(){
                PeliculasEnCartelera = peliculasEnCartelera,
                ProximosEstrenos = proximosEstrenos
            };
            return response;
        }

        /* Consultar por un registro determinado */
       [HttpGet("{id}")]
        public async Task<ActionResult<ShowMovie>>Get(int id)
        {
            var movie = await context.Movies.Where(x => x.Id == id)
            .Include(x => x.CategoriesMovie).ThenInclude(x => x.FilmGenre)
            .Include(x => x.MoviesActor).ThenInclude(x => x.Actor).FirstOrDefaultAsync();
 
            if (movie == null) { return NotFound();}
            var usrVote = 5;
            var avgVote = 5;
            var model = new ShowMovie();
            model.Movie = movie;
            movie.MoviesActor = movie.MoviesActor.OrderBy(x => x.OrderCredits).ToList();
            
            model.FilmGenres = movie.CategoriesMovie.Select(x=>x.FilmGenre).ToList();
            model.Actors = movie.MoviesActor.Select(x => new Actor{
                Name = x.Actor.Name,
                Photo = x.Actor.Photo,
                Character = x.Character,
                Id = x.ActorId}).ToList();
            
            model.AvgVote = avgVote;
            model.UserVote = usrVote;
            return model;
        }
        
        /* Finalmente: */

        public class ParametrosBusqueda
        {
            public int Pagina { get; set; } = 1;
            public int CantidadRegistros { get; set; } = 10;
            public Pagination Pagination
            {
                get { return new Pagination() { Pagina = Pagina, CantidadRegistros = CantidadRegistros }; }
            }
            public string Name { get; set; }
            public int CategoryId { get; set; }
            public bool EnCartelera { get; set; }
            public bool MasVotadas { get; set; }
        }

        [HttpGet("searchMovie")]
        public async Task<ActionResult<List<Movie>>> Get([FromQuery] ParametrosBusqueda parametrosBusqueda)
        {
            var movieQuery = context.Movies.AsQueryable();
            if (!string.IsNullOrWhiteSpace(parametrosBusqueda.Name))
            {
                movieQuery = movieQuery.Where(x=>x.Title.ToLower().Contains(parametrosBusqueda.Name.ToLower()));
            }
            if (parametrosBusqueda.EnCartelera)
            {
                movieQuery = movieQuery.Where(x=>x.EnCartelera);
            }
            /* if (parametrosBusqueda.Estrenos)
            {
                var currentDate = DateTime.Today;
                movieQuery = movieQuery.Where(x=>x.ProximosEstrenos >= currentDate);
            } */
            if (parametrosBusqueda.CategoryId !=0)
            {
                movieQuery = movieQuery.Where(x=>x.CategoriesMovie.Select(y=>y.FilmGenreId).Contains(parametrosBusqueda.CategoryId));
            }
            var movies = await movieQuery.Paginar(parametrosBusqueda.Pagination).ToListAsync();
            return movies;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Movie movie)
        {
            var movieDB = await context.Movies.FirstOrDefaultAsync(x=>x.Id == movie.Id);
            if (movieDB == null)
            {
                return NotFound();
            }
            movieDB = Mapper.Map(movie, movieDB);
            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var posterM = Convert.FromBase64String(movie.Poster);
                movieDB.Poster = await FilesStorage.EditFile(posterM,"jpg","movies",movieDB.Poster);
            }
            await context.Database.ExecuteSqlInterpolatedAsync($"delete from CategoriesMovie WHERE MovieId = {movie.Id}");
            if (movie.MoviesActor != null)
            {
                for (int i = 0; i < movie.MoviesActor.Count; i++)
                {
                    movie.MoviesActor[i].OrderCredits = i+1;
                }
            }
            movieDB.MoviesActor = movie.MoviesActor;
            movieDB.CategoriesMovie = movie.CategoriesMovie;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist_movie = await context.Movies.AnyAsync(x => x.Id == id);
            if (!exist_movie)
            {
                return NotFound();
            }
            context.Remove(new Movie{Id = id});
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}