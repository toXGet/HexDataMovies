using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HexDataMovies.Shared.Entity
{
    public class Actor
    {
        public int Id {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Name {get;set;}
        public string Photo {get;set;}
        public Gender Gender {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public DateTime? BirthDate {get;set;}
        /* Del paso a paso se quitó Id y Photo, se añadió lo siguiente:*/
        public DocumentType DocumentType {get;set;}
        public string Document {get;set;}
        public int KnownCredits {get;set;}
        public int Nominations {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Biography {get;set;}

        /* Campo que no se va a almacenar en ninguna tabla de la BD */
        [NotMapped]
        public string Character{get;set;}

        /* Relación MUCHOS a MUCHOS con la entidad Movies */
        public List<MovieActor> MoviesActor {get;set;}
        /* Del jueves se añade los siguientes para pruebas */
        public override bool Equals(object obj)
        {
            if (obj is Actor actor2)
            {
                return Id == actor2.Id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
    public enum DocumentType{
        CedulaCiudadania = 0,
        CedulaExtranjeria = 1,
        Pasaporte = 2,
        RegistroCivil = 3
    }
    public enum Gender{
        Femenino = 0,
        Masculino = 1,
        NonBinary = 2
    }
}