using System;
using System.Net;

namespace nilnul.time._zone._daylightSaving._transitionS
{
	/// <summary>
	/// 	/// Currently, daylight saving time starts on the second Sunday in March and ends on the first Sunday in November, with the time changes taking place at 2:00 a.m. local time. With a mnemonic word play referring to seasons, clocks "spring forward and fall back"—that is, in springtime the clocks are moved forward from 2:00 a.m. to 3:00 a.m., and in fall they are moved back from 2:00 a.m. to 1:00 a.m.

	/// </summary>
	public class Usa
	{
		static public TimeZoneInfo.TransitionTime Spring=  TimeZoneInfo.TransitionTime.CreateFloatingDateRule(
				new DateTime(
					1, 1, 1,	//useless
					2, 0, 0
				)
				,3	//march
				,5	//last
				, DayOfWeek.Sunday
			);

		static public TimeZoneInfo.TransitionTime Autumn = TimeZoneInfo.TransitionTime.CreateFloatingDateRule(
				new DateTime(
					1, 1, 1,	//useless
					2, 0, 0
				)
				,11	//nov
				,1	//first
				, DayOfWeek.Sunday

			);

		static public TimeSpan Delta = new TimeSpan(1, 0, 0);
		

	}
}
