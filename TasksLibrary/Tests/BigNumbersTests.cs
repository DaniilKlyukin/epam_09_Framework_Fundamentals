using TasksLibrary;
using NUnit.Framework;
using MSUnit = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestFixture]
    [MSUnit.TestClass]
    class BigNumbersTests
    {
        [TestCase("1234", "1234", ExpectedResult = "2468")]
        [TestCase("12", "324", ExpectedResult = "336")]
        [TestCase("124", "6", ExpectedResult = "130")]
        [TestCase("1978645321348794532134879", "987645312378986453242134789", ExpectedResult = "989623957700335247774269668")]
        [TestCase("99999999999999999999999999999999999999999999999999999", "1", ExpectedResult = "100000000000000000000000000000000000000000000000000000")]
        public string CheckBigNumbersSum(string num1, string num2)
        {
            return BigNumbersWorker.Sum(num1, num2);
        }
    }
}
