using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_.rfc_.monthly_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _IntervaledX
	{
		/// <summary>
		/// eg:
		///		RRULE:FREQ=MONTHLY;INTERVAL=3;BYMONTHDAY=11
		/// </summary>
		/// <param name="interval">
		/// must be positive;
		/// eg:
		///		1
		///		6
		/// </param>
		/// <param name="dayOfMonth">
		/// must be in [1,31]
		/// note: if for a month, there is no such day, it's ignored. eg:
		///		for 31, we have no Feb.31. so Februray is ignored.
		///	You can also use negative number. eg: -1 means the last day of a month. hence for feb, it's feb28, or feb29 depends on what year we are in.
		/// </param>
		/// <returns></returns>
		static public string _ToRrule_0interval_1index8month(int interval, int dayOfMonth) {
			return $"RRULE:FREQ=MONTHLY;INTERVAL={interval};BYMONTHDAY={dayOfMonth}";
		}
	}

}
