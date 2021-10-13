using AutoMapper;
using HexDataMovies.Shared.Entity;

namespace HexDataMovies.Server.Storage
{
    public class AutoMapperRegisters:Profile
    {
        public AutoMapperRegisters()
        {
            CreateMap<Actor, Actor>().ForMember(x=>x.Photo, option =>option.Ignore());
            CreateMap<Movie, Movie>().ForMember(x=>x.Poster, option =>option.Ignore());
        }
    }
}