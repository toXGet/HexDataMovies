using System;
using HexDataMovies.Shared.Entity;
using System.Collections.Generic;

namespace HexDataMovies.Client.Services
{
    public class ServiceActor : IServiceActor
    {
        public List<Actor> GetActors(){
            return new List<Actor>{
                new Actor(){Name="Actor 1",Photo="",Gender=Gender.Masculino,DocumentType=DocumentType.Pasaporte,Document="80799015",Biography="El actor nació, vivió y murió.",KnownCredits=1,Nominations=2,BirthDate=new DateTime(2003,11,14)},
                new Actor(){Name="Actor 2",Photo="",Gender=Gender.Femenino,DocumentType=DocumentType.CedulaExtranjeria,Document="105381142",Biography="El actor nació, vivió y murió.",KnownCredits=2,Nominations=2,BirthDate=new DateTime(1999,10,15)},
                new Actor(){Name="Actor 3",Photo="",Gender=Gender.NonBinary,DocumentType=DocumentType.CedulaCiudadania,Document="80799015",Biography="El actor nació, vivió y murió.",KnownCredits=3,Nominations=1,BirthDate=new DateTime(1998,10,12)},
                new Actor(){Name="Actor 4",Photo="",Gender=Gender.Masculino,DocumentType=DocumentType.CedulaCiudadania,Document="105381142",Biography="El actor nació, vivió y murió.",KnownCredits=4,Nominations=2,BirthDate=new DateTime(2021,09,01)},
                new Actor(){Name="Actor 5",Photo="",Gender=Gender.Masculino,DocumentType=DocumentType.CedulaCiudadania,Document="105381142",Biography="El actor nació, vivió y murió.",KnownCredits=5,Nominations=2,BirthDate=new DateTime(1941,03,07)},
                new Actor(){Name="Actor 6",Photo="",Gender=Gender.Femenino,DocumentType=DocumentType.CedulaCiudadania,Document="80799015",Biography="El actor nació, vivió y murió.",KnownCredits=6,Nominations=1,BirthDate=new DateTime(2000,09,15)},
                new Actor(){Name="Actor 7",Photo="",Gender=Gender.Femenino,DocumentType=DocumentType.CedulaCiudadania,Document="105381142",Biography="El actor nació, vivió y murió.",KnownCredits=7,Nominations=2,BirthDate=new DateTime(1977,03,21)},
                new Actor(){Name="Actor 8",Photo="",Gender=Gender.NonBinary,DocumentType=DocumentType.CedulaCiudadania,Document="105381142",Biography="El actor nació, vivió y murió.",KnownCredits=8,Nominations=1,BirthDate=new DateTime(2021,08,11)},
                new Actor(){Name="Actor 9",Photo="",Gender=Gender.NonBinary,DocumentType=DocumentType.Pasaporte,Document="80799015",Biography="El actor nació, vivió y murió.",KnownCredits=9,Nominations=2,BirthDate=new DateTime(1997,07,12)},
                new Actor(){Name="Actor 10",Photo="",Gender=Gender.Masculino,DocumentType=DocumentType.CedulaExtranjeria,Document="105381142",Biography="El actor nació, vivió y murió.",KnownCredits=10,Nominations=2,BirthDate=new DateTime(1972,03,15)},
                new Actor(){Name="Actor 11",Photo="",Gender=Gender.Masculino,DocumentType=DocumentType.RegistroCivil,Document="80799015",Biography="El actor nació, vivió y murió.",KnownCredits=6,Nominations=1,BirthDate=new DateTime(2021,07,30)},
                new Actor(){Name="Actor 12",Photo="",Gender=Gender.Masculino,DocumentType=DocumentType.Pasaporte,Document="105381142",Biography="El actor nació, vivió y murió.",KnownCredits=8,Nominations=1,BirthDate=new DateTime(2021,06,17)},
                new Actor(){Name="Actor 13",Photo="",Gender=Gender.Femenino,DocumentType=DocumentType.CedulaExtranjeria,Document="80799015",Biography="El actor nació, vivió y murió.",KnownCredits=1,Nominations=1,BirthDate=new DateTime(1990,07,13)},
                new Actor(){Name="Actor 14",Photo="",Gender=Gender.Femenino,DocumentType=DocumentType.Pasaporte,Document="105381142",Biography="El actor nació, vivió y murió.",KnownCredits=5,Nominations=2,BirthDate=new DateTime(1994,10,14)},
                new Actor(){Name="Actor 15",Photo="",Gender=Gender.Femenino,DocumentType=DocumentType.CedulaCiudadania,Document="105381142",Biography="El actor nació, vivió y murió.",KnownCredits=4,Nominations=2,BirthDate=new DateTime(1979,12,07)},
                new Actor(){Name="Actor 16",Photo="",Gender=Gender.NonBinary,DocumentType=DocumentType.CedulaCiudadania,Document="105381142",Biography="El actor nació, vivió y murió.",KnownCredits=3,Nominations=2,BirthDate=new DateTime(2010,08,06)}
            };
        }
    }
}