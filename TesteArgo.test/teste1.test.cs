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
            Assert.AreEqual(3, classeTeste.Subtrair(10, 7));
        }

        [TestMethod]
        public void teste1_Media()
        {
            Assert.AreEqual(30, classeTeste.Media(50, 20, 20));
            Assert.AreEqual(10, classeTeste.Media(10, 10, 10));
            Assert.AreEqual(50, classeTeste.Media(40, 50, 110,20,20,60));
        }
    }
}
