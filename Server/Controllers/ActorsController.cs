using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexDataMovies.Shared.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HexDataMovies.Server.Storage;
using System.Threading;

namespace HexDataMovies.Server.Controllers
{
    [ApiController]
        [Route("api/[controller]")]

        public class ActorsController: ControllerBase
        {
            private readonly ApplicationDbContext context;
            private readonly IFilesStorage FilesStorage;
            private readonly string carpeta = "actors";

            /* Para crear el registro en la base de datos, debemos inyectar el DbContext en el controlador */
            public ActorsController(ApplicationDbContext context, IFilesStorage filesStorage){
                this.context = context;
                this.FilesStorage = filesStorage;
            }

            [HttpPost]
            public async Task<ActionResult<int>> Post(Actor actor){
                if (!string.IsNullOrWhiteSpace(actor.Photo))
                {
                    var actor_photo = Convert.FromBase64String(actor.Photo);
                    actor.Photo = await FilesStorage.SaveFile(actor_photo, ".jpg", carpeta);
                }
                context.Add(actor);
                await context.SaveChangesAsync();
                return actor.Id;
            }
        }
}