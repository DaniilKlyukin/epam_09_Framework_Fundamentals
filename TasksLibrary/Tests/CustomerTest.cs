using TasksLibrary;
using NUnit.Framework;
using MSUnit = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [MSUnit.TestClass]
    [TestFixture]
    public class CustomerTest
    {
        Customer customer = new Customer()
        {
            Name = "Jeffrey Richter",
            ContactPhone = "+1 (425) 555-0100",
            Revenue = 1234567.89M
        };

        [TestCase(CustomerInfo.Name, CustomerInfo.Revenue, CustomerInfo.Phone, ExpectedResult = "Jeffrey Richter, 1,234,567.89, +1 (425) 555-0100")]
        [TestCase(CustomerInfo.Name, CustomerInfo.Phone, CustomerInfo.Revenue, ExpectedResult = "Jeffrey Richter, +1 (425) 555-0100, 1,234,567.89")]
        [TestCase(CustomerInfo.Name, CustomerInfo.Phone, CustomerInfo.None, ExpectedResult = "Jeffrey Richter, +1 (425) 555-0100")]
        [TestCase(CustomerInfo.Phone, CustomerInfo.Name, CustomerInfo.None, ExpectedResult = "+1 (425) 555-0100, Jeffrey Richter")]
        [TestCase(CustomerInfo.Name, CustomerInfo.None, CustomerInfo.None, ExpectedResult = "Jeffrey Richter")]
        [TestCase(CustomerInfo.Phone, CustomerInfo.None, CustomerInfo.None, ExpectedResult = "+1 (425) 555-0100")]
        [TestCase(CustomerInfo.None, CustomerInfo.Phone, CustomerInfo.None, ExpectedResult = "+1 (425) 555-0100")]
        [TestCase(CustomerInfo.None, CustomerInfo.None, CustomerInfo.Phone, ExpectedResult = "+1 (425) 555-0100")]
        public string CustomerToStringTest(CustomerInfo firstField, CustomerInfo secondField, CustomerInfo thirdField)
        {
            return customer.ToString(firstField, secondField, thirdField);
        }
    }
}
