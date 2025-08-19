using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.op_.weeky_
{
	/// <summary>
	/// 
	/// the day of the thence diemOfWeek;
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	static public class _ThenceX
	{
		/// <summary>
		/// find nearest day in future or on today, such that the dayOfWeek is as specified;
		/// </summary>
		/// <param name="from"></param>
		/// <param name="dayOfWeek"></param>
		/// <returns></returns>
		public static DateTime ThenceWeekdiem(this DateTime from, DayOfWeek dayOfWeek)
		{
			// The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
			return from.AddDays(
				(
					  (int)dayOfWeek- (int)(from.DayOfWeek) +7
					 
				)
				%
				7
			);


		}

		public static DateTime ThenceWeekdiem( DayOfWeek dayOfWeek)
		{
			return ThenceWeekdiem(DateTime.Now.Date,dayOfWeek)	;


		
		}


	}
}
