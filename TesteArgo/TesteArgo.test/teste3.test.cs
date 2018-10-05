using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteArgo.test
{
    [TestClass]
    public class teste3test
    {
        teste3 classeTeste = new teste3();

        [TestMethod]
        public void teste3_NomesComPrimeirasLetrasMaiusculas()
        {
            var resultado = classeTeste.NomesComPrimeirasLetrasMaiusculas("joao da silva pereira");

            Assert.IsNotNull(resultado);
            Assert.AreEqual("Joao da Silva Pereira", resultado);
        }


        [TestMethod]
        public void teste3_RemoverNomeDoMeio()
        {
            var resultado = classeTeste.RemoverNomeDoMeio("cleber reis pereira");

            Assert.IsNotNull(resultado);
            Assert.AreEqual("Cleber Pereira", resultado);

            resultado = classeTeste.RemoverNomeDoMeio("armando pompilio pomposo reis pereira");

            Assert.IsNotNull(resultado);
            Assert.AreEqual("Armando Pereira", resultado);
        }
    }
}
