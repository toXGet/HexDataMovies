using System.Net.Http;

namespace HexDataMovies.Client.Services
{
    public class HttpResponseWraper<T>
    {
        public bool Error {get;set;}
        public T Response {get;set;}
        public HttpResponseMessage HttpResponseMessage {get;set;}

        /* Constructor de la clase que espera 3 parametros siempre que se instancie desde otra clase */
        public HttpResponseWraper(T response, bool error, HttpResponseMessage httpResponseMessage){
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }
    }
}