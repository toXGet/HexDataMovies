using HexDataMovies.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HexDataMovies.Server.Storage;
using HexDataMovies.Shared.Configuration;

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

        public MoviesController(ApplicationDbContext context, IFilesStorage filesStorage){
            this.context = context;
            this.FilesStorage = filesStorage;
        }
        /* Almacena la Información de la película */

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var movie_poster = Convert.FromBase64String(movie.Poster);
                movie.Poster = await FilesStorage.SaveFile(movie_poster,".jpg", carpeta);
            }

            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }

        /* Listar peliculas por filtro de Películas en Cartelera y Próximos estrenos*/
        [HttpGet]
        public async Task<ActionResult<FilterMovie>>Get(){
            /* Paginación => datatable o cantidad de peliculas => cards */
            var limit = 10;
            var peliculasEnCartelera = await context.Movies.Where(x=> x.EnCartelera).Take(limit).OrderByDescending(x=>x.Premier).ToListAsync();
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
        public async Task<ActionResult>Get(int id){
            var movie = await context.Movies.Where(x=>x.Id ==id)
            .Include(x => x.CategoriesMovie).ThenInclude(x => x.FilmGenre)
            .Include(x => x.MoviesActor).ThenInclude(x => x.Actor).FirstOrDefaultAsync();
 
            if (movie == null) { return NotFound();}
            return NoContent();
 
        }
    }
}