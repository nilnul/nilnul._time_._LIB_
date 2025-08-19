using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.bounds.txten_
{
	/*
	 icalendar.org/iCalendar-RFC-5545/3-8-5-2-recurrence-date-times.html

The following are examples of this property

 RDATE:19970714T123000Z
 RDATE;TZID=America/New_York:19970714T083000
 RDATE;VALUE=PERIOD:19960403T020000Z/19960403T040000Z,
  19960404T010000Z/PT3H
 RDATE;VALUE=DATE:19970101,19970120,19970217,19970421
  19970526,19970704,19970901,19971014,19971128,19971129,19971225

	 */
	/// <summary>
	/// 
	/// </summary>
    static public class _IcalX
    {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string _OfBound8icalEs(IEnumerable<string> bounds) {
			return string.Join(",", bounds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string _OfBound8icalEs(params string[] bounds) {
			return _OfBound8icalEs( bounds);
		}

    }
}
