using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_
{
	///developers.google.com/calendar/api/concepts/events-calendars
	///UNTIL — The date or date-time until which the event should be repeated (inclusive).
	/// 
	/// <summary>
	/// until is inclusive for rfc.
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// unlike in nilnul, til is inclusive, while until(before) is exclusive. 
	///
	/// alias:
	///		on
	static public  class _UntilX
	{

		public const string KEY = "UNTIL";
		///icalendar.org/iCalendar-RFC-5545/3-3-10-recurrence-rule.html#:~:text=These%20rule%20parts%20MUST%20be,MONTHLY%20or%20YEARLY%20"RRULE".
		/// <summary>
		///The UNTIL rule part defines a DATE or DATE-TIME value that bounds the recurrence rule in an inclusive manner.
		///If the value specified by UNTIL is synchronized with the specified recurrence, this DATE or DATE-TIME becomes the last instance of the recurrence.
		///
		///The value of the UNTIL rule part MUST have the same value type as the "DTSTART" property.
		///
		/// (date)
		///		Furthermore, if the "DTSTART" property is specified as a date with local time, then the UNTIL rule part MUST also be specified as a date with local time.
		///		If the "DTSTART" property is specified as a date with UTC time or a date with local time and time zone reference, then the UNTIL rule part MUST be specified as a date with UTC time. In the case of the "STANDARD" and "DAYLIGHT" sub-components the UNTIL rule part MUST always be specified as a date with UTC time.
		///	(/date)
		///		
		///If specified as a DATE-TIME value, then it MUST be specified in a UTC time format. 
		/// 
		/// </summary>
		/// <param name="tilInclusive"></param>
		/// <returns></returns>
		///


		static public string _AsPart_0utc(DateTime tilInclusive)
		{
			return nilnul.obj.attr._PhraseX.Phrase(
				KEY
				,
				tilInclusive.ToString(
					"yyyyMMddThhmmssZ"      /// is "yyyyMMdd" ok?
				)
			);
			//return  $"UNTIL={tilInclusive.ToString(
			//	"yyyyMMddThhmmssZ"      /// is "yyyyMMdd" ok?
			//)}";
		}
		static public string AsPart(DateTime tilInclusive)
		{
			return nilnul.obj.attr._PhraseX.Phrase(
				KEY
				,
				tilInclusive.ToString(
					"yyyyMMddThhmmss"
				)
			);
		}


		static public string AsPart_0date(DateTime tilInclusive)
		{
			return nilnul.obj.attr._PhraseX.Phrase(
				KEY
				,
				tilInclusive.ToString(
					"yyyyMMdd"     
				)
			);

			//return $"UNTIL={tilInclusive.ToString(
			//	"yyyyMMdd"      /// is "yyyyMMdd" ok?
			//)}";
		}


		static public string AsPart(DateTimeOffset tilInclusive) {

			return _AsPart_0utc(tilInclusive.ToUniversalTime().DateTime);

			//return 	$"UNTIL={tilInclusive.ToUniversalTime().ToString(
			//	"yyyyMMddThhmmssZ"		/// is "yyyyMMdd" ok?
			//)}";
		}




	}
}
