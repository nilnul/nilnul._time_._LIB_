using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._date.year.month
{
	static public class _WeeksX
	{

		public static IEnumerable<List<DateTime>> WeeksInMonth(
			int year, int month, DayOfWeek base8week= DayOfWeek.Sunday
		)
		{

			int days8month = DateTime.DaysInMonth(year, month);

			DateTime currentDay = new(year, month, 1);
			List<DateTime> currentWeek = [currentDay];


			for (int i = 1; i < days8month; i++)	/// int is efficient than date
			{
				currentDay=currentDay.AddDays(1);

				if (currentDay.DayOfWeek == base8week )
				{
					yield return currentWeek;
					currentWeek = [];
				}

				currentWeek.Add(currentDay);

			}

			yield return currentWeek;
		}

	}
}
