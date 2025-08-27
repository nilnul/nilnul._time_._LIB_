using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_
{
	/// <summary>
	///  The FREQ rule part is REQUIRED, but MUST NOT occur more than once.
	/// </summary>
	/// 
	public enum Freq
	{
		SECONDLY,
		MINUTELY,
		HOURLY
			,
		/// <summary>
		/// Daily
		/// </summary>
		DAILY,
		WEEKLY,
		/// <summary>
		/// need to capitalize;
		/// </summary>

		MONTHLY,
		YEARLY




	}
}
