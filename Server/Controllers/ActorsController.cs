using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexDataMovies.Shared.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HexDataMovies.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ActorsController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        /* Para crear el registro en la base de datos, debemos inyectar el DbContext en el controlador */
        public ActorsController(ApplicationDbContext context){
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Actor actor){
            context.Add(actor);
            await context.SaveChangesAsync();
            return actor.Id;
        }
    }
}