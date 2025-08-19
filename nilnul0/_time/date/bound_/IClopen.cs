using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.bound_
{
	/// why is the latter date is exclusive?
	/// ans:
	///		when a day, or an hour, or any bound is taken as a time point|instant, it refers to the initial of that period. Eg: 15:00 means 15:00:00. That is: the remained finer grain is defaulted to zero, as always;
	///		;hence, to be in alignment with this, the latter shall be regarded as the beginning of the next day, and the next day shall then be excluded.
	///
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// eg:
	///		in google calendar for allDay events, the bound is a clopen on dates, timezoned;
	/// </remarks>
	/// alias:
	///		era
	///		thence
	///			,from then on,and so force
	///		hereto
	///		subsequent
	///		since
	///		asOf
	///		thereafter
	///		force
	///		
	internal class IClopen
	{
	}
}
