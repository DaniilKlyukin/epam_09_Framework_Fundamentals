using TasksLibrary;
using NUnit.Framework;
using MSUnit = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestFixture]
    [MSUnit.TestClass]
    class StringToTitleCaseTests
    {
        [TestCase("a clash of KINGS", "a an the of", ExpectedResult = "A Clash of Kings")]
        [TestCase("THE WIND IN THE WILLOWS", "The In", ExpectedResult = "The Wind in the Willows")]
        [TestCase("the quick brown fox", ExpectedResult = "The Quick Brown Fox")]
        [TestCase("sO sTrANGe leTTer tO TiTLe Case", "so to", ExpectedResult = "So Strange Letter to Title Case")]
        [TestCase("Hi", "hi", ExpectedResult = "Hi")]
        public string CheckToTitleCase(string text, string exceptionWords = "")
        {
            return StringWorker.ToTitleCase(text, exceptionWords);
        }
    }
}
