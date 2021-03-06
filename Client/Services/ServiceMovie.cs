using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Net.Http;
using HexDataMovies.Shared.Entity;

namespace HexDataMovies.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        /* Identificar el tipo de request por parte del cliente: POST, GET, DELETE, UPDATE */
        private readonly HttpClient httpClient;

        /* Constructor de la clase */
        public ServiceMovie(HttpClient httpClient){
            this.httpClient = httpClient;
        }

        private JsonSerializerOptions OpcionesPorDefectoJSON => new JsonSerializerOptions() {PropertyNameCaseInsensitive = true};

        /* Crear registros de películas en la Web API
        Tipo de request: POST */
        public async Task<HttpResponseWraper<object>> Post<T>(string url, T send){
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, sendContent);
            return new HttpResponseWraper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        /* Los siguientes dos métodos nos permitiran obtener el Id de la pelicula que acabo de crear */
        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }

        public async Task<HttpResponseWraper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(responseHttp, OpcionesPorDefectoJSON);
                return new HttpResponseWraper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWraper<TResponse>(default, true, responseHttp);
            }
        }

        /* METODO CONSULTAR */
        public async Task<HttpResponseWraper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWraper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWraper<T>(default, true, responseHTTP);
            }
        }
        /* MÉTODO MODIFICAR */
        public async Task<HttpResponseWraper<object>> Put<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWraper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        /* MÉTODO ELIMINAR */
        public async Task<HttpResponseWraper<object>> Delete(string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWraper<object>(null, !responseHTTP.IsSuccessStatusCode, responseHTTP);
        }

        public List<Movie> GetMovies(){
            return new List<Movie>{
                new Movie(){Title="El Viaje de Chihiro",Poster="/Images/Chihiro.jpg",Sinopsis="Una joven, Chihiro, queda atrapada en un nuevo y extraño mundo de espíritus. Cuando sus padres sufren una misteriosa transformación, ella debe recurrir al coraje que nunca supo que tenía para liberar a su familia.",Trailer="Animación",Language="Japonés",Country="Japón",Score=8.5F,/* RunningTime=new TimeSpan(2,5,0), */Premier=new DateTime(2003,11,14)},
                new Movie(){Title="Fight Club",Poster="/Images/FightClub.jpg",Sinopsis="Un insomne a punto de estallar y un resbaladizo vendedor de jabón canalizan la agresión masculina primaria en una nueva e impactante forma de terapia. Su concepto se pone de moda, con clubes de lucha subterráneos formándose en cada ciudad, hasta que un excéntrico se interpone en sus caminos y enciende una espiral fuera de control hacia la destrucción.",Trailer="Drama",Language="Inglés",Country="Estados Unidos",Score=8.4F,/* RunningTime=new TimeSpan(2,19,0), */Premier=new DateTime(1999,10,15)},
                new Movie(){Title="La vita è bella",Poster="/Images/LaVita.jpg",Sinopsis="Una conmovedora historia de un vendedor de libros italiano de ascendencia judía que vive en su propio pequeño cuento de hadas. Su vida creativa y feliz se detendría abruptamente cuando toda su familia fuera deportada a un campo de concentración durante la Segunda Guerra Mundial. Mientras está encerrado, trata de convencer a su hijo de que todo es solo un juego.",Trailer="Comedia",Language="Italiano",Country="Italia",Score=8.8F,/* RunningTime=new TimeSpan(1,56,0), */Premier=new DateTime(1998,10,12)},
                new Movie(){Title="Shang-Chi and the Legend of the Ten Rings",Poster="/Images/ShangChi.jpg",Sinopsis="Shang-Chi debe enfrentarse al pasado que creía haber dejado atrás cuando se ve atraído por la red de la misteriosa organización de los Diez Anillos.",Trailer="Aventura",Language="Inglés",Country="Estados Unidos",Score=7.9F,/* RunningTime=new TimeSpan(2,12,0), */Premier=new DateTime(2021,09,01)},
                new Movie(){Title="The Great Dictator",Poster="/Images/TheGreatDictator.jpg",Sinopsis="El dictador Adenoid Hynkel intenta expandir su imperio mientras un pobre barbero judío trata de evitar la persecución del régimen de Hynkel.",Trailer="Comedia",Language="Inglés",Country="Estados Unidos",Score=8.4F,/* RunningTime=new TimeSpan(2,5,0), */Premier=new DateTime(1941,03,07)},
                new Movie(){Title="O Auto da Compadecida",Poster="/Images/OAuto.jpg",Sinopsis="El animado Jack el Grillo y el suave Chicó son tipos pobres que viven en el interior que engañan a un grupo de personas en un pequeño pueblo en el noreste de Brasil. Cuando mueren, tienen que ser juzgados por Cristo, el Diablo y la Virgen María antes de ser admitidos en el paraíso.",Trailer="Aventura",Language="Portugués",Country="Brasil",Score=8.5F,/* RunningTime=new TimeSpan(1,44,0), */Premier=new DateTime(2000,09,15)},
                new Movie(){Title="Star Wars",Poster="/Images/StarWars.jpg",Sinopsis="La princesa Leia es capturada y retenida como rehén por las malvadas fuerzas imperiales en su esfuerzo por apoderarse del Imperio galáctico. El aventurero Luke Skywalker y el apuesto capitán Han Solo se unen al adorable dúo de robots R2-D2 y C-3PO para rescatar a la hermosa princesa y restaurar la paz y la justicia en el Imperio.",Trailer="Ciencia Ficción",Language="Inglés",Country="Estados Unidos",Score=8.2F,/* RunningTime=new TimeSpan(2,1,0), */Premier=new DateTime(1977,03,21)},
                new Movie(){Title="Free Guy",Poster="/Images/FreeGuy.jpg",Sinopsis="Un cajero de banco llamado Guy se da cuenta de que es un personaje de fondo en un videojuego de mundo abierto llamado Free City que pronto se desconectará.",Trailer="Comedia",Language="Inglés",Country="Estados Unidos",Score=7.8F,/* RunningTime=new TimeSpan(1,55,0), */Premier=new DateTime(2021,08,11)},
                new Movie(){Title="La Princesa Mononoke",Poster="/Images/Mononoke.jpg",Sinopsis="Ashitaka, un príncipe del pueblo Emishi que desaparece, es maldecido por un dios jabalí demonizado y debe viajar al oeste para encontrar una cura. En el camino, se encuentra con San, una joven humana que lucha por proteger el bosque, y Lady Eboshi, que está tratando de destruirlo. Ashitaka debe encontrar una manera de equilibrar este conflicto.",Trailer="Animación",Language="Japonés",Country="Japón",Score=8.4F,/* RunningTime=new TimeSpan(2,14,0), */Premier=new DateTime(1997,07,12)},
                new Movie(){Title="The Godfather",Poster="/Images/TheGodFather.jpg",Sinopsis="Abarcando los años 1945 a 1955, una crónica de la ficticia familia criminal italoamericana Corleone. Cuando el patriarca de la familia del crimen organizado, Vito Corleone, apenas sobrevive a un atentado contra su vida, su hijo menor, Michael, interviene para encargarse de los posibles asesinos, lanzando una campaña de venganza sangrienta.",Trailer="Drama",Language="Inglés",Country="Estados Unidos",Score=8.7F,/* RunningTime=new TimeSpan(2,55,0), */Premier=new DateTime(1972,03,15)},
                new Movie(){Title="Le Dernier Mercenaire",Poster="/Images/Derniere.jpg",Sinopsis="Un misterioso ex agente del servicio secreto debe regresar urgentemente a Francia cuando su hijo separado es acusado falsamente de tráfico de armas y drogas por el gobierno, después de un error de un burócrata demasiado celoso y una operación mafiosa.",Trailer="Acción",Language="Francés",Country="Francia",Score=6.9F,/* RunningTime=new TimeSpan(1,50,0), */Premier=new DateTime(2021,07,30)},
                new Movie(){Title="Luca",Poster="/Images/Luca.jpg",Sinopsis="Luca y su mejor amigo Alberto experimentan un verano inolvidable en la Riviera italiana. Pero toda la diversión está amenazada por un secreto profundamente guardado: son monstruos marinos de otro mundo justo debajo de la superficie del agua.",Trailer="Animación",Language="Inglés",Country="Reino Unido",Score=8.0F,/* RunningTime=new TimeSpan(1,35,0), */Premier=new DateTime(2021,06,17)},
                new Movie(){Title="Mi Vecino Totoro",Poster="/Images/Totoro.jpg",Sinopsis="Dos hermanas se mudan al campo con su padre para estar más cerca de su madre hospitalizada, y descubren que los árboles circundantes están habitados por Totoros, espíritus mágicos del bosque. Cuando la más joven huye de casa, la hermana mayor busca la ayuda de los espíritus para encontrarla.",Trailer="Fantasía",Language="Japonés",Country="Japón",Score=8.1F,/* RunningTime=new TimeSpan(1,26,0), */Premier=new DateTime(1990,07,13)},
                new Movie(){Title="Pulp Fiction",Poster="/Images/PulpFiction.jpg",Sinopsis="Un sicario amante de las hamburguesas, su compañero filosófico, un gángster drogadicto y un boxeador lavado convergen en esta extensa y cómica alcaparra criminal. Sus aventuras se despliegan en tres historias que ingeniosamente tropiezan de un lado a otro en el tiempo.",Trailer="Thriller",Language="Inglés",Country="Estados Unidos",Score=8.5F,/* RunningTime=new TimeSpan(2,34,0), */Premier=new DateTime(1994,10,14)},
                new Movie(){Title="Star Trek: The Motion Picture",Poster="/Images/StarTreck.jpg",Sinopsis="Cuando una entidad espacial destructiva es vista acercándose a la Tierra, el Almirante Kirk reanuda el mando de la Nave Estelar Enterprise para interceptarla, examinarla y, con suerte, detenerla.",Trailer="Ciencia Ficción",Language="Inglés",Country="Estados Unidos",Score=6.4F,/* RunningTime=new TimeSpan(2,12,0), */Premier=new DateTime(1979,12,07)},
                new Movie(){Title="Inception",Poster="/Images/Inception.jpg",Sinopsis="A Cobb, un hábil ladrón que comete espionaje corporativo infiltrándose en el subconsciente de sus objetivos, se le ofrece la oportunidad de recuperar su antigua vida como pago por una tarea considerada imposible: la incepción, la implantación de la idea de otra persona en el subconsciente de un objetivo.",Trailer="Ciencia Ficción",Language="Inglés",Country="Estados Unidos",Score=8.3F,/* RunningTime=new TimeSpan(2,28,0), */Premier=new DateTime(2010,08,06)}
            };
        }
    }
}