using FileHelpers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace KeePassCPEO.Tests
{
    [TestClass]
    public class CustomDateOptionTest
    {
        [DataTestMethod]
        [DynamicData(nameof(GetCustomDateOptionStringValidationData), DynamicDataSourceType.Method)]
        [DeploymentItem(@"Sample Data\CustomDateOptionStringValidationData.csv")]
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

        public static IEnumerable<object[]> GetCustomDateOptionStringValidationData()
        {
            var engine = new FileHelperEngine<CustomDateOptionStringValidationDataRecord>();
            engine.Options.IgnoreFirstLines = 1;

            var records = engine.ReadFile(@"Sample Data\CustomDateOptionStringValidationData.csv");

            foreach (var record in records)
            {
                yield return new object[]
                {
                    record.Days,
                    record.Months,
                    record.Years,
                    record.ExpectedString
                };
            }
        }
    }
}