using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class teste4
    {
        ///www.omdbapi.com/
        const string ApiKey = "18693fd6";

        /// <summary>
        /// By Search
        /// www.omdbapi.com/?s=titulo&apikey=18693fd6
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Filme> ListarFilmes(string filtro)
        {
            return null;
        }

        /// <summary>
        /// By ID or Title
        /// www.omdbapi.com/?i=tt0372784&apikey=18693fd6
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Filme ListarPorId(string id)
        {
            return null;
        }
    }

    public class Filme
    {
        /// <summary>
        /// Title
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Year
        /// </summary>
        public int? Ano { get; set; }
        /// <summary>
        /// imdbID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Poster
        /// </summary>
        public string Imagem { get; set; }
    }
}
