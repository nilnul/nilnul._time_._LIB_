using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace nilnul.time.zone.eg
{
	/// <summary>
	/// </summary>
	public class UsaCentral
	{
		public const int OffSet = -6;	

		public const bool usingDaylightSaving = true;

		static public TimeZoneInfo timeZone= TimeZoneInfo.CreateCustomTimeZone(
				"Central Time" //id
				, new TimeSpan(OffSet, 0, 0)	//offset to UTC

				, "Central Time "  //display name

				, "Central Standard Time "  //std name
				, "Central Daylight Savings Time "  //dst name

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

		static public bool IsDaylightSavingTime(DateTime localtime) {

			return timeZone.IsDaylightSavingTime(localtime);

		}

		static public bool IsDaylightSavingTime(int year,int month,int day) {

			return IsDaylightSavingTime(new DateTime(year,month, day));

		}


		static public DateTime ToUtc(DateTime localTime) {

			return localTime - timeZone.GetUtcOffset(localTime);

		}

		

		static public DateTime ToUtc(int year, int month,int day, int hour=0,int minute=0,int seconds=0) {

			return ToUtc(new DateTime(year,month,day,hour,minute,seconds));

		}


        static public DateTime Now {
            get
            {
                return DateTime.UtcNow+  timeZone.GetUtcOffset(new DateTimeOffset(
                    DateTime.UtcNow,TimeSpan.Zero
                    ));
            }
        }

	


	}
}
