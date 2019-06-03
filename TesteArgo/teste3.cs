using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Models;

namespace TesteArgo
{
    public class teste3
    {
        ///www.omdbapi.com/
        const string ApiKey = "18693fd6";
        private RestClient client;

        public teste3()
        {
            this.client = new RestClient("http://www.omdbapi.com");
        }

        /// <summary>
        /// By Search
        /// www.omdbapi.com/?s=titulo&apikey=18693fd6
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Filme> ListarFilmes(string filtro)
        {
            var request = new RestRequest("/", Method.GET);
            request.AddParameter("s", filtro);
            request.AddParameter("apikey", ApiKey);


            IRestResponse<ResponseSearch> response = client.Execute<ResponseSearch>(request);

            var retorno = new List<Filme>();

            foreach (var filme in response.Data.Search)
            {
                retorno.Add(new Filme
                {
                    ID = filme.imdbID,
                    Titulo = filme.Title,
                    Ano = int.Parse(filme.Year.Substring(0, 4)),
                    Imagem = filme.Poster
                });
            }

            return retorno;
        }

        /// <summary>
        /// By ID or Title
        /// www.omdbapi.com/?i=tt0372784&apikey=18693fd6
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Filme ListarPorId(string id)
        {
            var request = new RestRequest("/", Method.GET);
            request.AddParameter("i", id);
            request.AddParameter("apikey", ApiKey);


            IRestResponse<ResponseMovie> response = client.Execute<ResponseMovie>(request);

            return new Filme
            {
                ID = response.Data.imdbID,
                Titulo = response.Data.Title,
                Ano = response.Data.Year,
                Imagem = response.Data.Poster
            };
        }
    }
}
