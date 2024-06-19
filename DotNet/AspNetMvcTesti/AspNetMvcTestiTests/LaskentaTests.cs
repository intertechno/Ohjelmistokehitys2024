using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetMvcTesti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTesti.Tests
{
    [TestClass()]
    public class LaskentaTests
    {
        [TestMethod()]
        public void SummaTest()
        {
            Laskenta laskenta = new();
            int a = 1;
            int b = 2;
            int expected = a + b;

            int actual = laskenta.Summa(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Summa2Test()
        {
            Laskenta laskenta = new();
            int a = 1;
            int b = 2;
            int expected = a + b;

            int actual = laskenta.Summa2(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}