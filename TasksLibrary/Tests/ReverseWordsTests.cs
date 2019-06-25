using TasksLibrary;
using NUnit.Framework;
using MSUnit = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestFixture]
    [MSUnit.TestClass]
    class ReverseWordsTests
    {
        [TestCase("The greatest victory is that which requires no battle",
            ExpectedResult = "battle no requires which that is victory greatest The")]
        [TestCase("one two three four five six seven eight nine ten",
            ExpectedResult = "ten nine eight seven six five four three two one")]
        [TestCase("word", ExpectedResult = "word")]
        [TestCase("A B C D E F G", ExpectedResult = "G F E D C B A")]
        public string CheckReverseWords(string text)
        {
            return Reverser.ReverseWords(text);
        }
    }
}
