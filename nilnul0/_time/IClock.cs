using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time
{
	/// <summary>
	/// date + shift|drift ( clock|timespan ) = the time to be defined.
	/// 
	/// time of a day, namely, hours/minutes/seconds/ticks/..., which are integers except seconds, which, in line with System.DateTime, is an integer of ticks . fraction of tick is rounded to nil.
	/// for nonnil tick, derive a subtype from this. Just as we have different physical clocks in the room of various precisions. for example, some old mechnic clock has no second hand, some chipped clock can have precision of milliseconds able to be used in race match sport, and computer clock of precision in tick( 100nanoscecond, or 0.1 microsecond, or 0.000 1 millisecond)
	/// 
	/// A single tick represents one hundred nanoseconds or one ten-millionth of a second. There are 10,000 ticks in a millisecond (see TicksPerMillisecond) and 10 million ticks in a second.
	/// 
	/// for a fraction of seconds, <see cref="nameof()"/>
	/// </summary>
	/// <remarks>
	///		<seealso cref="Instant,Duration"/>
	/// </remarks>
	interface  IClock
	{
	}

}
