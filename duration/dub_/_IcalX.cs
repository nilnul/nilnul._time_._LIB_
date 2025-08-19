using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration.dub_
{
	/*
icalendar.org/iCalendar-RFC-5545/3-3-6-duration.html


A duration of 15 days, 5 hours, and 20 seconds would be

 P15DT5H0M20S


A duration of 7 weeks would be:

 P7W
	 */

	/// <summary>
	/// <see cref="elapse.dub_._IcalX"/>
	/// </summary>
	/// <remarks>
	/// eg:
	///		PT1
	///			,in which T1 means one hour
	/// </remarks>
	static public class _IcalX
	{
		/// <summary>
		/// unprefixed
		/// </summary>
		/// <param name="hours"></param>
		/// <param name="minutes"></param>
		/// <param name="seconds"></param>
		/// <returns></returns>
		static public string _TimePart_0hours_1minutes_2seconds( int hours, int minutes, int seconds)
		{
			return $"T{hours}H{minutes}M{seconds}S";
			//return $"P{days}DT{hours}H{minutes}M{seconds}S";
		}
		static public string _Dub_0days_1hours_2minutes_3seconds(int days, int hours, int minutes, int seconds)
		{
			return $"{_Dub_0days(days)}{_TimePart_0hours_1minutes_2seconds(hours,minutes,seconds)}";
			//return $"P{days}DT{hours}H{minutes}M{seconds}S";
		}

		static public string _Dub_0hours_1minutes_2seconds( int hours, int minutes, int seconds)
		{
			return $"P{_TimePart_0hours_1minutes_2seconds(hours,minutes,seconds)}";
			//return $"P{days}DT{hours}H{minutes}M{seconds}S";
		}


		static public string _Dub_0days(int days)
		{
			return $"P{days}D";
		}


		static public string _Dub_0weeks(int weeks)
		{
			return $"P{weeks}W";
		}
	}
}
