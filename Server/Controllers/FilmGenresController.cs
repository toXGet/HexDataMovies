using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
/* using Microsoft.Extensions.Logging;
using HexDataMovies.Shared; */
using HexDataMovies.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace HexDataMovies.Server.Controllers
{
    [ApiController]
    /* El [controller] tomará el nombre del controlador, en este caso FilmGenreController */
    [Route("api/[controller]")]

    public class FilmGenresController: ControllerBase
    {
        /* Los únicos métodos que reciben como parámetro la entidad son:
                [HttpPost] => POST(Add) => Crear registro
                [HttpPut] => PUT (Attach) => Actualizar registro   */
        /* El método que no recibe parámetro es:
                [HttpGet] => GET(ToListAsync) => Consultar historial de registros  */
        /* Los métodos que reciben como parámetro el Id son:
                [HttpDelete("{id}")] => DELETE (Remove) => Eliminar registro
                [HttpGet("{id}")] => GET[{id}] (FirstOrDefaultAsync) => Consultar por un registro específico*/

        /* Inicializamos el application db context a la cual le creamos recursos mediante add */
        private readonly ApplicationDbContext context;
        
        /* Para crear el registro en la base de datos, debemos inyectar el DbContext en el controlador. 
        Constructor del Controlador */
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

        /* Consultar registros en la base de datos (Lista TODOS los registros)*/
        [HttpGet]
        public async Task<ActionResult<List<FilmGenre>>> Get(){
            return await context.FilmGenres.ToListAsync();
        }

        /* Consultar la información de determinado recurso */
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmGenre>> Get(int id){
            return await context.FilmGenres.FirstOrDefaultAsync(x => x.Id == id);
        }

        /* Actualizar la información de determinado registro */
        [HttpPut]
        public async Task<ActionResult> Put(FilmGenre filmGenre){
            context.Attach(filmGenre).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        /* Borrar determinado registro */
        [HttpDelete("{id}")]
        public async Task <ActionResult> Delete (int id){
            var exists = await context.FilmGenres.AnyAsync(x => x.Id == id);
            /* Si no existe un registro con ese Id */
            if(!exists){return NotFound();}
            context.Remove(new FilmGenre {Id = id});
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}