using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.texfy_.alnum_
{
	///icalendar.org/iCalendar-RFC-5545/3-3-5-date-time.html
	///
	/// 
	/// <summary>
	/// DATE-TIME values of this type are said to be "floating" and are not bound to any time zone in particular. 
	/// </summary>
	/// <see cref="nilnul.txt_.word_.IAlnum"/>
	/// 
	static public class _Year8fourX
	{
		public const string FORMAT = nilnul._time.date.phrase_.num_.YearInFour.FORMAT + "T" + _time.clock.texfy_._NumX.FORMAT;

		static public string Phrase(DateTime dateTime) {

			return dateTime.ToString(
				FORMAT
			);
		}
	}


}
