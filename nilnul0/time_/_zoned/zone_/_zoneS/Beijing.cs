using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace nilnul.time._zoneS
{
	/// <summary>
	/// </summary>
	public class Beijing
	{
		public const int OffSet = 8;

		public const bool usingDaylightSaving = false;

		static public TimeZoneInfo timeZone = TimeZoneInfo.CreateCustomTimeZone(
				"Beijing Time"  //id
				, new TimeSpan(OffSet, 0, 0)

				, "(GMT+08:00) Beijing Time"    //display name
				, "Beijing Time"    //std name
				);

		static public TimeSpan offsetTimeSpan = new TimeSpan(8,0,0);
		static public DateTimeOffset CreateDateTimeOffset(int year,int month,int day,int hour) {
			return new DateTimeOffset(year, month, day, hour, 0, 0, offsetTimeSpan);
		}




	}
}
