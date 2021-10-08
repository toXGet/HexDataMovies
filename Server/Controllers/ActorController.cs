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

    public class ActorController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        public ActorController(ApplicationDbContext context){
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