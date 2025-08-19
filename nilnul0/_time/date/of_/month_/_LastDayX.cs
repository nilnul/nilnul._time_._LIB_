using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.of_.month_
{
	/// <summary>
	/// get the last day of a month
	/// </summary>
	static public class _LastDayX
	{
		/// <summary>
		/// last day of current month
		/// </summary>
		/// <returns></returns>
		static public int Day() {
			return Day(DateTime.Now);
		}
		static public int Day(DateTime now) {
			return DateTime.DaysInMonth(now.Year,now.Month);
		}


	}
}
