using System.Collections.Generic;

namespace nilnul.time.seq_.ical_._rfc.clauz_
{

	/*
developers.google.com/calendar/api/concepts/events-calendars

	 */

	/*
	 icalendar.org/iCalendar-RFC-5545/3-8-5-2-recurrence-date-times.html


	 */
	/// <summary>
	///	RDATE: This property defines the list of DATE-TIME values for      recurring events, to-dos, journal entries, or time zone      definitions.
	/// eg:
	///	RDATE:19970714T123000Z
	///	RDATE;TZID=America/New_York:19970714T083000
	/// RDATE;VALUE=PERIOD:19960403T020000Z/19960403T040000Z,        19960404T010000Z/PT3H
	/// RDATE;VALUE=DATE:19970101,19970120,19970217,19970421        19970526,19970704,19970901,19971014,19971128,19971129,19971225
	/// 
	/// </summary>

	/// <see cref="nilnul.time.bound_.clopen.texfy_._IcalX"/>
	/// <see cref="nilnul.time.duration.dub_._IcalX"/>
	/// 
	static public class _RdateX
	{
		public const string PREFIX = "RDATE";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="periods">
		/// nonempty, 
		/// of which each item is returned by <see cref="nilnul.time.duration.dub_._IcalX"/>;
		/// </param>
		/// <returns></returns>
		static public string _Rdate_0periods(IEnumerable<string> periods) {
			return $"{PREFIX};VALUE=PERIOD:{string.Join(",",periods)}";
		}
	}


}
