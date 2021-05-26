using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenges;
using System.Text.RegularExpressions;

namespace CodeChallenges.UnitTests
{
    [TestClass]
    public class PrimeNumberDecompTests
    {
        [TestMethod]
        public void Factors_ArgLessThanOne_ReturnMessage()
        {
            string pattern = @"\b\w+[No]\w+";
            string result = PrimeNumberDecomposition.Factors(1);

            Regex rg = new Regex(pattern);
            Assert.IsTrue(rg.IsMatch(result));
        }


        [TestMethod]
        public void Factors_PrimeArg_ReturnSelfAsString()
        {
            string expected = "(257)";
            string actual = PrimeNumberDecomposition.Factors(257);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factors_NonPrimeArg_ReturnInTypicalFormat()
        {
            string expected = "(2**2)(3**3)(5)(7)(11**2)(17)";
            string actual = PrimeNumberDecomposition.Factors(7775460);

            Assert.AreEqual(expected, actual);
        }
    }
}
