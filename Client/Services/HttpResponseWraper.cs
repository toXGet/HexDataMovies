using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

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

        /* La función que faltaba para que funcionaran los controllers que la llamaban */
        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}