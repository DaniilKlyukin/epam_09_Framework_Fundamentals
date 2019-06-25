using TasksLibrary;
using NUnit.Framework;
using MSUnit = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestFixture]
    [MSUnit.TestClass]
    class AddOrChangeUrlParameterTests
    {
        [TestCase("www.example.com", "key=value", ExpectedResult = "www.example.com?key=value")]
        [TestCase("www.example.com?key=oldValue", "key=newValue", ExpectedResult = "www.example.com?key=newValue")]
        [TestCase("www.example.com?key1=oldValue1&key2=oldValue2&key3=oldValue3", "key2=newValue", ExpectedResult = "www.example.com?key1=oldValue1&key2=newValue&key3=oldValue3")]
        [TestCase("www.key.com?key=oldValue", "key=newValue", ExpectedResult = "www.key.com?key=newValue")]
        [TestCase("www.example.com?key1=oldValue1&key2=oldValue2&key3=oldValue3", "key4=newValue", ExpectedResult = "www.example.com?key1=oldValue1&key2=oldValue2&key3=oldValue3&key4=newValue")]
        public string CheckAddOrChangeUrlParameter(string url, string keyValueParameter)
        {
            return URLManipulator.AddOrChangeUrlParameter(url, keyValueParameter);
        }
    }
}
