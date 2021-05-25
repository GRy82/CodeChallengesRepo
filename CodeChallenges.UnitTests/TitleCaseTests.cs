using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenges;

namespace CodeChallenges.UnitTests
{
    [TestClass]
    public class TitleCaseTests
    {
        [TestMethod]
        public void TitleCase_HappyPath_EqualStrings()
        {
            string expected = "Of Mice and Men";
            string actual = TitleCaseChallenge.TitleCase("of mice And Men", "oF AND in the");
            Assert.AreEqual(expected, actual);
        }
       
        [TestMethod]
        public void TitleCase_EmptyMinorWordsArg_MinorWordsIgnored()
        {
            string expected = "Of Mice And Men";
            string actual = TitleCaseChallenge.TitleCase("of mice And Men", "");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TitleCase_EmptyTitleArg_BlankResult()
        {
            string expected = "";
            string actual = TitleCaseChallenge.TitleCase("", "and of the");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TitleCase_EmptyStringArgs_BlankResult()
        {
            string expected = "";
            string actual = TitleCaseChallenge.TitleCase("", "");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TitleCase_NullMinorWordsArg_Unaffected()
        {
            string expected = "Of Mice And Men";
            string actual = TitleCaseChallenge.TitleCase("of mice and men", null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException), "title cannot be null.")]
        public void TitleCase_NullTitleString_ThrowException()
        {
            string expected = "Of Mice And Men";
            string actual = TitleCaseChallenge.TitleCase(null, "of the");
            Assert.AreEqual(expected, actual);
        }
    }
}
