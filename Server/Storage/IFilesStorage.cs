using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexDataMovies.Server.Storage
{
    public interface IFilesStorage
    {
        Task<string> SaveFile(byte[] contenido, string extension, string nombreCarpeta);
        Task DeleteFile(string ruta, string nombreCarpeta);
        Task<string> EditFile(byte[] contenido,string extension, string nombreCarpeta,string ruta);
    }
}