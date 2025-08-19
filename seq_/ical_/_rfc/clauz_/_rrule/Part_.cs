using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule
{
	///
	/// https://icalendar.org/iCalendar-RFC-5545/3-3-10-recurrence-rule.html
	/// <summary>
	/// 
	/// </summary>
	internal enum Part_
	{
		/// <summary>
		/// <see cref="part_.Freq"/>
		/// </summary>
		Freq
			,
		/// <summary>
		///  date / date-time
		/// </summary>
		Until
			,
		/// <summary>
		/// 1 or more digits;
		/// </summary>
		Count
			,
		Interval
			,
		/// <summary>
		/// a comma separated list, each item of which is:
		/// 1 or 2 digits to represent 0~60. 
		/// </summary>
		BYSECOND,
		/// <summary>
		/// a comma separated list, each item of which is:
		/// 1 or 2 digits to represent 0~59. 
		/// 
		/// </summary>

		BYMINUTE
			,
		/// <summary>
		/// a comma separated list, each item of which is:
		/// 1 or 2 digits to represent 0~23. 
		/// 
		/// </summary>
		BYHOUR
		,
		/// <summary>"SU" / "MO" / "TU" / "WE" / "TH" / "FR" / "SA"
		/// 
		/// </summary>
		BYDAY
		,
		BYMONTHDAY
		,
		BYYEARDAY
		,
		/// <summary>
		/// a comma separated list, each item of which is:
		///  (+|-)?/d{1,2}
		///  that is optional sign, followed by 1 or 2 digits to represent 1-53. 
		/// 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		BYWEEKNO
		,

		BYMONTH
		,
		/// <summary>
		/// a COMMA-separated list of values that corresponds to the nth occurrence within the set of recurrence instances specified by the rule.Valid values are 1 to 366 or -366 to -1. It MUST only be used in conjunction with another BYxxx rule part.
		/// </summary>
		/// <remarks>
		///For example "the last work day of the month" could be represented as:
		///FREQ=MONTHLY;BYDAY=MO,TU,WE,TH,FR;BYSETPOS=-1
		/// </remarks>
		BYSETPOS
		,
		/// <summary>
		/// Valid values are MO, TU, WE, TH, FR, SA, and SU.
		/// The default value is MO;
		/// </summary>
		WKST
	}
}
