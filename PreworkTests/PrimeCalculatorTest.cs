using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prework;

namespace PreworkTests
{
    [TestClass]
    public class PrimeCalculatorTest
    {
        [TestMethod]
        public void TestFirstPrime()
        {
            Assert.AreEqual(2, PrimeCalculator.Calculate(1), "First prime was not 2.");
        }

        [TestMethod]
        public void TestSecondPrime()
        {
            Assert.AreEqual(3, PrimeCalculator.Calculate(2), "Second prime was not 3.");
        }

        [TestMethod]
        public void TestThirdPrime()
        {
            Assert.AreEqual(5, PrimeCalculator.Calculate(3), "Thrid prime was not 5.");
        }

        [TestMethod]
        public void TestSeventhPrime()
        {
            Assert.AreEqual(17, PrimeCalculator.Calculate(7), "Seventh prime was not 17.");
        }

        [TestMethod]
        public void TestHundredthPrime()
        {
            Assert.AreEqual(541, PrimeCalculator.Calculate(100), "Hundredth prime was not 541.");
        }
    }
}
