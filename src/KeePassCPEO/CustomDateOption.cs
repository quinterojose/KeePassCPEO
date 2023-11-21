using System;
using System.Collections.Generic;

namespace KeePassCPEO
{
    /// <summary>
    /// A custom date option entry.
    /// </summary>
    public class CustomDateOption : IComparable<CustomDateOption>
    {
        /// <summary>
        /// Gets or sets the number of days.
        /// </summary>
        /// <value>The number of days.</value>
        public int Days { get; set; }

        /// <summary>
        /// Gets or sets the number of months.
        /// </summary>
        /// <value>The number of months.</value>
        public int Months { get; set; }

        /// <summary>
        /// Gets or sets the number of years.
        /// </summary>
        /// <value>The number of years.</value>
        public int Years { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var parts = new List<string>();

            if (Years > 0)
                parts.Add(string.Format("{0} {1}", Years, Pluralize(Years, "Year", "Years")));

            if (Months > 0)
                parts.Add(string.Format("{0} {1}", Months, Pluralize(Months, "Month", "Months")));

            if (Days > 0)
                parts.Add(string.Format("{0} {1}", Days, Pluralize(Days, "Day", "Days")));

            if (parts.Count == 0)
                return string.Empty;

            return string.Join(", ", parts);
        }

        /// <summary>
        /// Returns a <see cref="DateTime"/> that represents the current <see cref="CustomDateOption"/>.
        /// </summary>
        /// <returns>A <see cref="DateTime"/> that represents the current <see cref="CustomDateOption"/>.</returns>
        public DateTime ToDate()
        {
            return DateTime.Now.AddDays(Days).AddMonths(Months).AddYears(Years).Date;
        }

        private static string Pluralize(int number, string singular, string plural)
        {
            if (number == 1)
                return singular;
            else
                return plural;
        }

        /// <inheritdoc/>
        public int CompareTo(CustomDateOption other)
        {
            throw new NotImplementedException();
        }
    }
}
