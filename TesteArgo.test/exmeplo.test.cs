using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Threading.Tasks;

namespace TesteArgo.test
{
    [TestClass]
    public class exmeplo
    {
		[TestMethod]
		public void exmeplo_teste()
        {
            Assert.IsTrue(new exemplo().Exemplo());
        }
    }
}
