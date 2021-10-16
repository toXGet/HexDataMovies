using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace HexDataMovies.Shared.Entity
{
    public class Movie
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Title {get;set;}
        public string Poster {get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Sinopsis {get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Trailer {get;set;}
        public bool EnCartelera {get; set;}
        // public string Genero {get;set;}
        public string Language {get;set;}
        public string Country {get;set;}
        public float Score {get;set;}
        /* public TimeSpan RunningTime {get;set;} */
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime? Premier {get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        /* Relación de MUCHOS a MUCHOS con FilmGenre, Mediante relación CategoryMovie */
        public List<CategoryMovie> CategoriesMovie {get;set;} = new List<CategoryMovie>();
        /* Relación de UNO a MUCHOS con Actor, mediante MovieActor */
        public List<MovieActor> MoviesActor {get;set;}
        
        public string ShortTitle
        {
            get{
                if (string.IsNullOrWhiteSpace(Title))
                {
                    return null;
                }
                if (Title.Length > 60)
                {
                    return Title.Substring(0, 60) + "...";
                }else{
                    return Title;
                }
            }
        }
    }
}