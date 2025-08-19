using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc
{

	/// 
	/// The "EXDATE" property can be used to exclude the value specified in "DTSTART".
	/// https://datatracker.ietf.org/doc/html/rfc5545#section-3.8.5.1
	/// This property defines the list of DATE-TIME exceptions for      recurring events, to-dos, journal entries, or time zone      definitions.
	/// 
	/// eg:
	///		EXDATE:19960402T010000Z,19960403T010000Z,19960404T010000Z
	/// eg:
	/// DTSTART;TZID=America/New_York:19970902T090000
	/// EXDATE;TZID=America/New_York:19970902T090000
	/// RRULE:FREQ=MONTHLY;BYDAY=FR;BYMONTHDAY=13
	///


	static  class _ExDateX
	{
						//"EXDATE;VALUE=DATE:20240818"
				//"EXDATE:20240818"




///
				//$"EXDATE;TZID={nilnul.time_._zoned.zone_._ShanghaiX.IANA}:20240818T130000"

				/// stackoverflow.com/questions/60373797/google-calendar-api-recurrent-event-exdate-not-working
				///
				/// Since you provided a dateTime for start and end, you should also provide a dateTime in EXDATE, and the time part should match the one you provided in start. Otherwise, the API won't know what event to exclude.
				/// That is to say, the recurrence should be like this:
				/// "RRULE:FREQ=DAILY;UNTIL=20200229T185959Z;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR,SA,SU",
				/// "EXDATE;TZID=Asia/Karachi:20200225T183000"
				///


				/*stackoverflow.com/questions/56400844/getting-exdate-to-work-when-creating-google-recurring-event

using local time without TZID or Z worked, i. e.

EXDATE:20190617T090000
				 */





	}


}
