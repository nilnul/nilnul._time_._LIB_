using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_.rfc_.yearly_
{
	/// <summary>
	/// </summary>
	static public class _MultipleX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="months">
		/// eg:
		///		1
		///		1,6
		/// </param>
		/// <param name="dayOfMonth">
		/// eg: in [1,31]
		/// note: if for a month, there is no such day, it's ignored. eg:
		///		for 31, we have no Feb.31. so Februray is ignored.
		///	You can also use negative number. eg: -1 means the last day of a month. hence for feb, it's feb28, or feb29 depends on what year we are in.
		/// </param>
		/// <returns></returns>
		static public string _ToRrule_0months_1index8month(IEnumerable< int> months, int dayOfMonth) {
			return $@"RRULE:FREQ=YEARLY;INTERVAL=1;BYMONTH={
				nilnul.obj.str._PhraseX.Phrase(months)
			};BYMONTHDAY={dayOfMonth}";
		}
	}

}
