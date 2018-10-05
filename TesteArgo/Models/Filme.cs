using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.Models
{
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
