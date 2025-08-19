using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace nilnul.time.seq_.ical_._rfc.clauz
{
	///
	///https://datatracker.ietf.org/doc/html/rfc2445#section-4.8.5.4
	/// <summary>
	/// All names of properties, property parameters, enumerated property	values and property parameter valueare case-insensitive.However,   all other property values are case-sensitive, unless otherwise   stated.
	/// For example, the property name "DUE" is the same as   "due" and "Due", DTSTART;TZID=US-Eastern:19980714T120000 is the same   as DtStart;TzID=US-Eastern:19980714T120000.
	/// </summary>
	/// <remarks>
	/// Property parameter values that are not in quoted strings are case	insensitive.
	/// </remarks>
	/// boolean    = "TRUE" / "FALSE"
	/// Description: These values are case insensitive text.
	internal class ILetterCase
	{
	}
}
