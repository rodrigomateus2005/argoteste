using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteArgo.test
{
    [TestClass]
    public class teste1teste
    {
        teste1 classeTeste = new teste1();

        [TestMethod]
        public void teste1_soma()
        {
            Assert.AreEqual(6, classeTeste.Somar(1, 5));
        }

        [TestMethod]
        public void teste1_Subtrair()
        {
            Assert.AreEqual(2, classeTeste.Subtrair(5, 3));
        }

        [TestMethod]
        public void teste1_Media()
        {
            Assert.AreEqual(30, classeTeste.Media(50, 20, 20));
        }

        [TestMethod]
        public void teste1_CalcularIdade()
        {
            Assert.AreEqual(27, classeTeste.CalcularIdade(1990, 9, 22));
            Assert.AreEqual(20, classeTeste.CalcularIdade(1997, 5, 12));
        }
    }
}
