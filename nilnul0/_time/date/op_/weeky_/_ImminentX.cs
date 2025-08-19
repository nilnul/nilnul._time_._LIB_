using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.op_.weeky_
{
	/// <summary>
	/// the day of the immediate coming weekday;
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		imminent
	///			,next
	///	vs:
	///		<see cref="_ImmediateX"/>
	/// vs:
	///		<see cref="weeky_._NextX"/>,
	///			eg:
	///				today is monday. comming wednesday is in the same week;
	///				today is wedenesday, coming monday is in the next week;
	static public class _ImminentX
	{
		public static DateTime ImminentWeekday(this DateTime from, DayOfWeek dayOfWeek)
		{
			// The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
			return from.AddDays(
				(
					  (int)dayOfWeek- (int)(from.DayOfWeek) +7
					  -1 // convert from one-based to 0based.
				)
				%
				7
				+1		//convert from 0based to 1based.
			);


			//int start = (int)from.DayOfWeek;

			//int target = (int)dayOfWeek;

			//if (target <= start)
			//{
			//	target += 7;
			//}

			//return from.AddDays(target - start);
		}

		public static DateTime ImminentWeekday( DayOfWeek dayOfWeek)
		{
			return ImminentWeekday(DateTime.Now.Date,dayOfWeek)	;


		
		}


	}
}
