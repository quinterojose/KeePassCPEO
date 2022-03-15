using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KeePassCPEO.Tests
{
    [TestClass]
    public class CustomDateOptionTest
    {
        [DataTestMethod]
        [DataRow(1, 0, 0, "1 Day")]
        [DataRow(0, 1, 0, "1 Month")]
        [DataRow(0, 0, 1, "1 Year")]
        [DataRow(1, 1, 0, "1 Day, 1 Month")]
        [DataRow(0, 1, 1, "1 Month, 1 Year")]
        [DataRow(1, 0, 1, "1 Day, 1 Year")]
        [DataRow(1, 1, 1, "1 Day, 1 Month, 1 Year")]
        [DataRow(2, 0, 0, "2 Days")]
        [DataRow(0, 2, 0, "2 Months")]
        [DataRow(0, 0, 2, "2 Years")]
        [DataRow(2, 2, 0, "2 Days, 2 Months")]
        [DataRow(0, 2, 2, "2 Months, 2 Years")]
        [DataRow(2, 0, 2, "2 Days, 2 Years")]
        [DataRow(2, 1, 1, "2 Days, 1 Month, 1 Year")]
        [DataRow(2, 2, 1, "2 Days, 2 Months, 1 Year")]
        [DataRow(2, 2, 2, "2 Days, 2 Months, 2 Years")]
        [DataRow(1, 2, 1, "1 Day, 2 Months, 1 Year")]
        [DataRow(1, 1, 2, "1 Day, 1 Month, 2 Years")]
        [DataRow(2, 1, 2, "2 Days, 1 Month, 2 Years")]
        [DataRow(0, 0, 0, "")]
        public void CustomDateOption_ToString(int days, int months, int years, string expectedString)
        {
            var dateOption = new CustomDateOption
            {
                Days = days,
                Months = months,
                Years = years,
            };

            dateOption.ToString().Should().Be(expectedString);
        }
    }
}