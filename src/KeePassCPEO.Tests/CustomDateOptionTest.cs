using FileHelpers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace KeePassCPEO.Tests
{
    [TestClass]
    public class CustomDateOptionTest
    {
        [TestMethod]
        public void CustomDateOption_ToDate()
        {
            var expectedDateOptions = new List<CustomDateOption>
            {
                new CustomDateOption{ Days = 1 },
                new CustomDateOption{ Days = 2 },
                new CustomDateOption{ Months = 1, Days = 1 },
                new CustomDateOption{ Months = 1, Days = 2 },
                new CustomDateOption{ Years = 1 }
            };

            var actualDateOptions = new List<CustomDateOption>
            {
                new CustomDateOption{ Years = 1 },
                new CustomDateOption{ Days = 1 },
                new CustomDateOption{ Months = 1, Days = 2 },
                new CustomDateOption{ Months = 1, Days = 1 },
                new CustomDateOption{ Days = 2 }
            }.OrderBy(dateOption => dateOption.ToDate()).ToList();

            actualDateOptions.Should().BeEquivalentTo(expectedDateOptions);
        }

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