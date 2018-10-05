using System;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteArgo.test
{
    [TestClass]
    public class teste2test
    {
        teste2 classeTeste = new teste2();

        [TestMethod]
        public void teste2_criarlista()
        {
            var resultado = classeTeste.CriarLista(500);

            Assert.IsNotNull(resultado);
            Assert.AreEqual(500 , resultado.Count);
        }

        [TestMethod]
        public void teste2_OrdenarLista()
        {
            var resultado = classeTeste.OrdenarLista(8,9,6,5,6,4,3,25,89);

            Assert.IsNotNull(resultado);
            Assert.AreEqual(9, resultado.Count);

            Assert.AreEqual(3, resultado[0]);
        }
    }
}
