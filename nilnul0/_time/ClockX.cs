using System;

namespace nilnul._time
{
	/*I'd suggest you use a GUID instead of DateTime.Ticks to get your unique name - otherwise you'll get clashes if the DB code runs faster than expected.*/

	public class ClockX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="hours">
		/// can exceed 24. for example, 25 means the early morning of the next day.
		///		generally can exceed 24 til 36. that is the morning of the next day.
		/// can be negative. for example -1 means the midnight around the start of the day.
		///		can be as small as -12. that is the afternoon of the previous day. 
		/// </param>
		/// <param name="minutes"></param>
		/// <param name="seconds"></param>
		/// <returns></returns>
		static public TimeSpan Span(int hours, int minutes, int seconds) {

			return new TimeSpan(hours, minutes, seconds);
		}
	}

}
