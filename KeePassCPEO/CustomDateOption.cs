using System;
using System.Collections.Generic;
using System.Text;

namespace KeePassCPEO
{
    /// <summary>
    /// A custom date option entry.
    /// </summary>
    public class CustomDateOption
    {
        /// <summary>
        /// Gets or sets the number of days.
        /// </summary>
        public int Days { get; set; }

        /// <summary>
        /// Gets or sets the number of months.
        /// </summary>
        public int Months { get; set; }

        /// <summary>
        /// Gets or sets the number of years.
        /// </summary>
        public int Years { get; set; }

        /// <summary>
        /// Display the custom date option as a string.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            if (Days > 0)
                output.AppendFormat("{0} {1}", Days, Pluralize(Days, "Day", "Days"));

            if(Days > 0 && Months > 0)
                output.AppendFormat(", {0} {1}", Months, Pluralize(Months, "Month", "Months"));
            else if(Months > 0)
                output.AppendFormat("{0} Months", Months, Pluralize(Months, "Month", "Months"));

            if((Days > 0 || Months > 0) && Years > 0)
                output.AppendFormat(", {0} Years", Months, Pluralize(Years, "Year", "Years"));
            else if(Years > 0)
                output.AppendFormat("{0} Years", Months, Pluralize(Years, "Year", "Years"));

            if (output.Length == 0)
                output.Append("Invalid.");

            return output.ToString();
        }

        /// <summary>
        /// Pluralize the word.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="singular">The singular word.</param>
        /// <param name="plural">The plural word.</param>
        /// <returns>A string.</returns>
        private static string Pluralize(int number, string singular, string plural)
        {
            if (number == 1)
                return singular;
            else
                return plural;
        }
    }
}
