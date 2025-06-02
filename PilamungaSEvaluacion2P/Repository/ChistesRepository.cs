

using System.Net.Http.Json;
using PilamungaSEvaluacion2P.Models;

namespace PilamungaSEvaluacion2P.Repository
{
    internal class ChistesRepository
    {
        private readonly HttpClient httpClient=new();
        public async Task<Chiste> ObtenerChiste()
        {
            var url = "https://official-joke-api.appspot.com/random_joke";
            return await httpClient.GetFromJsonAsync<Chiste>(url);
        }
    }
}
