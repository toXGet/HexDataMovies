using HexDataMovies.Shared.Entity;
using System.Collections.Generic;

namespace HexDataMovies.Client.Services
{
    public interface IServiceActor
    {
        List<Actor> GetActors();
    }
}