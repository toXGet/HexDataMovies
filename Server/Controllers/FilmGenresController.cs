using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HexDataMovies.Shared;
using HexDataMovies.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace HexDataMovies.Server.Controllers
{
    [ApiController]
    /* El [controller] tomará el nombre del controlador, en este caso FilmGenreController */
    [Route("api/[controller]")]

    public class FilmGenresController: ControllerBase
    {
        /* Inicializamos el application db context a la cual le creamos recursos mediante add */
        private readonly ApplicationDbContext context;
        
        /* Para crear el registro en la base de datos, debemos inyectar el DbContext en el controlador */
        public FilmGenresController(ApplicationDbContext context){
            this.context = context;
        }

        /* Tipo de Solicitud del cliente: POST 
        crear un recurso*/
        [HttpPost]
        
        /* La tarea retorna un int correspondiente al Id de la categoría creada */
        public async Task<ActionResult<int>> Post(FilmGenre filmGenre){
            /* Con el método add agregamos el registro en la DB */
            context.Add(filmGenre);
            /* Aplicamos los cambios en la BD, para guardar cambios de forma asincrona con el await */
            await context.SaveChangesAsync();
            return filmGenre.Id;
        }
    }
}