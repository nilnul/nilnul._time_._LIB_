using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_
{
	///https://datatracker.ietf.org/doc/html/rfc5545#section-3.8.5
	///https://icalendar.org/iCalendar-RFC-5545/3-8-5-3-recurrence-rule.html
	///recur           = recur-rule-part *( ";" recur-rule-part )
	///, that is ';' is to separate between clauzes.
	/// <summary>
	/// the order carries no significance;
	/// </summary>
	/// <remarks>
	/// eg:
	///		RRULE:FREQ=DAILY;COUNT=10
	///		RRULE:FREQ=DAILY;UNTIL=19971224T000000Z
	///		RRULE:FREQ=DAILY;INTERVAL=2
	///		RRULE:FREQ=DAILY;INTERVAL=10;COUNT=5
	///		RRULE:FREQ=DAILY;UNTIL=20000131T140000Z;BYMONTH=1
	///			, in january;
	///		RRULE:FREQ=YEARLY;UNTIL=20000131T140000Z;BYMONTH=1;BYDAY=SU,MO,TU,WE,TH,FR,SA
	///			, in january
	///		RRULE:FREQ=WEEKLY;COUNT=10
	///		RRULE:FREQ=WEEKLY;UNTIL=19971224T000000Z
	///		RRULE:FREQ=WEEKLY;INTERVAL=2;WKST=SU
	///			, weekstart: sunday;
	///		RRULE:FREQ=WEEKLY;UNTIL=19971007T000000Z;WKST=SU;BYDAY=TU,TH
	///		RRULE:FREQ=WEEKLY;COUNT=10;WKST=SU;BYDAY=TU,TH
	///		RRULE:FREQ=WEEKLY;INTERVAL=2;UNTIL=19971224T000000Z;WKST=SU;BYDAY=MO,WE,FR
	///		RRULE:FREQ=WEEKLY;INTERVAL=2;COUNT=8;WKST=SU;BYDAY=TU,TH
	///		RRULE:FREQ=MONTHLY;COUNT=10;BYDAY=1FR
	///		RRULE:FREQ=MONTHLY;UNTIL=19971224T000000Z;BYDAY=1FR
	///		RRULE:FREQ=MONTHLY;INTERVAL=2;COUNT=10;BYDAY=1SU,-1SU
	///			, last sunday
	///		RRULE:FREQ=MONTHLY;COUNT=6;BYDAY=-2MO
	///		RRULE:FREQ=MONTHLY;BYMONTHDAY=-3
	///		RRULE:FREQ=MONTHLY;COUNT=10;BYMONTHDAY=2,15
	///		RRULE:FREQ=MONTHLY;COUNT=10;BYMONTHDAY=1,-1
	///		RRULE:FREQ=MONTHLY;INTERVAL=18;COUNT=10;BYMONTHDAY=10,11,12,13,14,15
	///		RRULE:FREQ=MONTHLY;INTERVAL=2;BYDAY=TU
	///		RRULE:FREQ=YEARLY;COUNT=10;BYMONTH=6,7
	///			, Yearly in June and July for 10 occurrences; the day would be gotten from the basic date.
	///		RRULE:FREQ=YEARLY;INTERVAL=2;COUNT=10;BYMONTH=1,2,3
	///		RRULE:FREQ=YEARLY;INTERVAL=3;COUNT=10;BYYEARDAY=1,100,200
	///		RRULE:FREQ=YEARLY;BYDAY=20MO
	///			,Every 20th Monday of the year, forever;
	///		RRULE:FREQ=YEARLY;BYWEEKNO=20;BYDAY=MO
	///		RRULE:FREQ=YEARLY;BYMONTH=3;BYDAY=TH
	///			,Every Thursday in March, forever
	///		RRULE:FREQ=YEARLY;BYDAY=TH;BYMONTH=6,7,8
	///		
	///		RRULE:FREQ=MONTHLY;BYDAY=FR;BYMONTHDAY=13
	///			,Every Friday the 13th, forever; if the 13th is not friday, it's excluded;
	///		RRULE:FREQ=MONTHLY;BYDAY=SA;BYMONTHDAY=7,8,9,10,11,12,13
	///			,The first Saturday that follows the first Sunday of the month,      forever
	///		RRULE:FREQ=YEARLY;INTERVAL=4;BYMONTH=11;BYDAY=TU;     BYMONTHDAY=2,3,4,5,6,7,8
	///		
	///		RRULE:FREQ=MONTHLY;COUNT=3;BYDAY=TU,WE,TH;BYSETPOS=3
	///			,BYSETPOS is not a rule by itself, actually it limits the rule. It means take the n-th instance from the calculated instances corresponding to the rest of the rule.
	///			
	/// </remarks>
	/// While support for multiple RRULE was there in RFC2445, it has been removed from RFC5545 for lack of interoperability between calendar agents. 


	static public class _RruleX
	{
		public const string KEY = "RRULE";

		static public string OfTgt(string parts) {
			return nilnul.obj.duo.Phrase.Unison.phrase(KEY, parts);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parts">
		/// <see cref="nilnul.obj.IAttr"/>s
		/// </param>
		/// <returns></returns>
		static public string OfParts(IEnumerable<string> parts) {
			return OfTgt(
				_rrule.parts._TexfyX._Texfy_0parts(parts)
			);
		}

		static public string OfParts(params string[] parts) {
			return OfTgt(
				_rrule.parts._TexfyX._Texfy_0parts(parts)
			);
		}



		/*
	 ; The FREQ rule part is REQUIRED,
                 ; but MUST NOT occur more than once.
			, that is one and only once;

; The UNTIL or COUNT rule parts are OPTIONAL,
                 ; but they MUST NOT occur in the same 'recur'.

 ; The other rule parts are OPTIONAL,
                 ; but MUST NOT occur more than once.
		 */

	}

	
}
