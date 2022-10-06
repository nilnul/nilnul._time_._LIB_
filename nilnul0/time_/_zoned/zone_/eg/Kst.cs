using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace nilnul.time.zone.eg
{
	/// <summary>
	/// </summary>
	public class Kst
	{
		public const int OffSet = 9;

		public const bool usingDaylightSaving = false;

		static public TimeZoneInfo timeZone = TimeZoneInfo.CreateCustomTimeZone(
				"Korean Standard Time"  //id
				, new TimeSpan(OffSet, 0, 0)

				, "(GMT+09:00) Korean Time"    //display name
				, "Korea Time"    //std name
				);

		static public TimeSpan offsetTimeSpan = new TimeSpan(9,0,0);
		static public DateTimeOffset CreateDateTimeOffset(int year,int month,int day,int hour=0, int minutes=0,int seconds=0) {
			return new DateTimeOffset(year, month, day, hour, minutes, seconds, offsetTimeSpan);
		}

		static public DateTime ToUtc(int year,int month,int day,int hour=0,int minute=0,int seconds=0 ) {
			return CreateDateTimeOffset(year, month, day, hour,minute,seconds).ToUniversalTime().DateTime;
		}




	}
}
