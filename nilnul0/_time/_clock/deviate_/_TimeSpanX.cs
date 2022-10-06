using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._clock.deviate_
{
	/// <summary>
	/// use <see cref="System.TimeSpan"/> to denote clock (time of the day).
	/// </summary>
	class _TimeSpanX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="hours"> can be negative, or more than 24. eg: -3, 27, 37</param>
		/// <param name="minutes">can be negative or more than 60</param>
		/// <param name="secons">can be neg or more than 60</param>
		/// <returns>unnormalized timespan. the numbers might be outside [0,60)</returns>
		static public TimeSpan RelativeToDate(int hours, int minutes, int secons) {
			return new TimeSpan(hours, minutes, secons);
		}

		/// <summary>
		/// negative or nonnegative days,
		///		plus
		/// nonnegative and in-range : hours, minutes, seconds, fractions.
		/// </summary>
		/// <param name="timeSpan"></param>
		/// <returns></returns>
		static public TimeSpan _Normalize(TimeSpan timeSpan) {
			var ms=timeSpan.TotalMilliseconds;
			if (ms >=0)
			{
				return TimeSpan.FromMilliseconds(ms);
			}

			var days= Math.Floor(ms * _measure.unit_.Milli4dbl.MAGNITUDE / _measure.unit_.Day4dbl.MAGNITUDE );
			var daysInSpan = TimeSpan.FromDays(days);
			return daysInSpan+ TimeSpan.FromMilliseconds(
				ms -  daysInSpan.TotalMilliseconds
			) ;
		}
	}
}
