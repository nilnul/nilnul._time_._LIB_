using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._date.year.month._weeks_.by_
{
	static public class _ByDateX
	{


		///https://gist.github.com/karenpayneoregon/7da928bc3db292fd0ece0c8da45dee1f
		/// 
		/// 
		/// <summary>
		/// Divides the days of a specified month and year into weeks, where each week is represented as a list of days.
		/// </summary>
		/// <param name="year">The year of the month to process.</param>
		/// <param name="month">The month to process (1 to 12).</param>
		/// <returns>A list of weeks, where each week is a list of <see cref="DateOnly"/> objects representing the days in that week.</returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Thrown when the <paramref name="month"/> is not in the range 1 to 12.
		/// </exception>
		/// 
		public static List<List<DateTime>> GetWeeksInMonth(int year, int month)
		{
			List<List<DateTime>> weeks = [];
			DateTime firstDay = new(year, month, 1);
			DateTime lastDay = new(year, month, DateTime.DaysInMonth(year, month));

			List<DateTime> currentWeek = [];

			for (var day = firstDay; day <= lastDay; day = day.AddDays(1))
			{
				if (day.DayOfWeek == DayOfWeek.Sunday && currentWeek.Count > 0)
				{
					weeks.Add(currentWeek);
					currentWeek = [];
				}

				currentWeek.Add(day);

				if (day == lastDay)
				{
					weeks.Add(currentWeek);
				}
			}

			return weeks;
		}

	
	}
}
