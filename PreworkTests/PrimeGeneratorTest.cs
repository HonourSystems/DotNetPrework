using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SMSMT.AE.Programming.Prework;

namespace SMSMT.AE.Programming.PreworkTests
{
    [TestClass]
    public class PrimeGeneratorTest
    {
        [TestMethod]
        public void TestFirstPrime()
        {
            Assert.AreEqual(2, PrimeGenerator.generate(1), "First prime was not 2.");
        }

        [TestMethod]
        public void TestSecondPrime()
        {
            Assert.AreEqual(3, PrimeGenerator.generate(2), "Second prime was not 3.");
        }

        [TestMethod]
        public void TestThirdPrime()
        {
            Assert.AreEqual(5, PrimeGenerator.generate(3), "First prime was not 5.");
        }

        [TestMethod]
        public void TestSeventhPrime()
        {
            Assert.AreEqual(17, PrimeGenerator.generate(7), "Seventh prime was not 17.");
        }

        [TestMethod]
        public void TestHundredthPrime()
        {
            Assert.AreEqual(541, PrimeGenerator.generate(100), "First prime was not 541.");
        }
    }
}
