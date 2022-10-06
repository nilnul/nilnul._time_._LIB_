using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace nilnul.time._zoneS
{
	/// <summary>
	/// </summary>
	public class Pacific
	{
		public const int OffSet = -8;

		public const bool usingDaylightSaving = true;

		static public TimeZoneInfo timeZone= TimeZoneInfo.CreateCustomTimeZone(
				"Pacific Time"	//id
				, new TimeSpan(OffSet, 0, 0)	//offset to UTC

				, "(GMT-08:00) Pacific Time"	//display name

				, "Pacific Standard Time"	//std name
				, "Pacific Daylight Time"	//dst name

				, new TimeZoneInfo.AdjustmentRule[] {
					 TimeZoneInfo.AdjustmentRule.CreateAdjustmentRule(
						new DateTime(1999, 10, 1)	//start
						,DateTime.MaxValue.Date	//end
						,_zone._daylightSaving._transitionS.Usa.Delta	//adjustment
						,_zone._daylightSaving._transitionS.Usa.Spring	//yearly start
						,_zone._daylightSaving._transitionS.Usa.Autumn	//yearly end
					)
				}
		);

	


	}
}
