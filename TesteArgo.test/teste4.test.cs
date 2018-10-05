using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.test
{
    [TestClass]
    public class teste4Test
    {
        teste4 classeTeste = new teste4();

        [TestMethod]
        public void teste4_ListarFilmes()
        {
            var resultado = classeTeste.ListarDestino();

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Count > 0);
        }


        [TestMethod]
        public void teste4_ListarPorId()
        {
            var resultado = classeTeste.buscarPorId(1);

            Assert.IsNotNull(resultado);            
        }
    }
}
