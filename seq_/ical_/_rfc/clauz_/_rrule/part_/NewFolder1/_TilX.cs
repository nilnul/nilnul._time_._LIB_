using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_.rfc._phrase
{
	[Obsolete(nameof(nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_._UntilX))]
	static public  class _TilX
	{
		///icalendar.org/iCalendar-RFC-5545/3-3-10-recurrence-rule.html#:~:text=These%20rule%20parts%20MUST%20be,MONTHLY%20or%20YEARLY%20"RRULE".
		/// <summary>
		///
		/// 
		/// </summary>
		/// <param name="tilInclusive"></param>
		/// <returns></returns>
		static public string AsPart(DateTimeOffset tilInclusive) {
			return 	$"UNTIL={tilInclusive.ToUniversalTime().ToString(
				"yyyyMMddThhmmssZ"		/// is "yyyyMMdd" ok?
			)}";
		}

		static public string AsPart(DateTime tilInclusive) {
			return 	$"UNTIL={tilInclusive.ToString(
				"yyyyMMddThhmmssZ"		/// is "yyyyMMdd" ok?
			)}";
		}


		static public string AsPart_0date(DateTime tilInclusive) {
			return 	$"UNTIL={tilInclusive.ToString(
				"yyyyMMdd"		/// is "yyyyMMdd" ok?
			)}";
		}




	}
}
