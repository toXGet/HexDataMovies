using System;
using System.ComponentModel.DataAnnotations;

namespace HexDataMovies.Shared.Entity
{
    public class Actor
    {
        public int Id {get;set;}
        [Required]
        public string Name {get;set;}
        public string Photo {get;set;}
        public Gender Gender {get;set;}
        [Required]
        public DateTime? BirthDate {get;set;}
        /* Del paso a paso se quitó Id y Photo, se añadió lo siguiente:*/
        public DocumentType DocumentType {get;set;}
        public string Document {get;set;}
        public int KnownCredits {get;set;}
        public int Nominations {get;set;}
        public string Biography {get;set;}
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