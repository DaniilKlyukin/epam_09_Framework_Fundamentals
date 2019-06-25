using TasksLibrary;
using NUnit.Framework;
using MSUnit = Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    [MSUnit.TestClass]
    class UniqOrdererTests
    {
        [TestCase(new double[] { 1.1, 2.2, 2.2, 3.3 }, ExpectedResult = new double[] { 1.1, 2.2, 3.3 })]
        [TestCase(new char[] { 'a', 'q', 'w', 'W', 'a', 'q' }, ExpectedResult = new char[] { 'a', 'q', 'w', 'W', 'a', 'q' })]
        [TestCase(new int[] { 0, 1, 1, 0, 1, 1 }, ExpectedResult = new int[] { 0, 1, 0, 1 })]
        [TestCase(new bool[] { false, true, true, false }, ExpectedResult = new bool[] { false, true, false })]
        public IEnumerable<T> CheckUniqOrdererIEnumerable<T>(IEnumerable<T> input)
        {
            return UniqOrderer.UniqueInOrder(input);
        }

        [TestCase("AAAABBBCCDAABBB", ExpectedResult = "ABCDAB")]
        [TestCase("ABBCcAD", ExpectedResult = "ABCcAD")]
        [TestCase("12233", ExpectedResult = "123")]
        public IEnumerable<char> CheckUniqOrdererString(IEnumerable<char> input)
        {
            return UniqOrderer.UniqueInOrder(input);
        }
    }
}
