using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.op_.weeky_
{
	/// <summary>
	/// the day of next week;
	/// </summary>
	/// vs:<see cref="weeky_._ImminentX"/>
	static public class _NextX
	{
		public static DateTime NextWeekday(this DateTime from, DayOfWeek dayOfWeek)
		{
			// The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
			return from.AddDays(
				
					 (int)dayOfWeek- (int)from.DayOfWeek + 7
			); //not modulo


			//int start = (int)from.DayOfWeek;

			//int target = (int)dayOfWeek;

			//if (target <= start)
			//{
			//	target += 7;
			//}

			//return from.AddDays(target - start);
		}

		public static DateTime NextWeekday( DayOfWeek dayOfWeek)
		{
			return NextWeekday(DateTime.Now.Date,dayOfWeek)	;


		
		}

		public static List<DateTime> NextWeekdays()
		{
			var nextSunday = DateTime.Now.Date.NextWeekday(DayOfWeek.Sunday);

			return Enumerable.Range(0, 7).Select(index =>
				nextSunday.AddDays(index)).ToList();
		}
	}
}
