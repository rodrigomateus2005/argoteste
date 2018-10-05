using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.test
{
    [TestClass]
    public class teste4test
    {
        teste4 classeTeste = new teste4();

        [TestMethod]
        public void teste4_ListarFilmes()
        {
            var resultado = classeTeste.ListarFilmes("batman");

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Count > 0);
        }


        [TestMethod]
        public void teste4_ListarPorId()
        {
            var resultado = classeTeste.ListarPorId("tt0372784");

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Titulo.ToLower().Contains("batman"));
        }
    }
}
