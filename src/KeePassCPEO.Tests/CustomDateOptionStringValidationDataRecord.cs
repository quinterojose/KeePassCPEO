using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeePassCPEO.Tests
{
    [DelimitedRecord("\t")]
    public class CustomDateOptionStringValidationDataRecord
    {
        public int Days { get; set; }
        public int Months { get; set; }
        public int Years { get; set; }
        public string ExpectedString { get; set; } = string.Empty;
    }
}
