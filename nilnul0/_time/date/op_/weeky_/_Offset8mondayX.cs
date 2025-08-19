using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.op_.weeky_
{
	/// <summary>
	/// monday offset, where a week is from monday to sunday.
	/// </summary>
	static public class _Offset8mondayX
	{
		public static DateTime Monday8ThisWeek(this DateTime from)
		{
			return from.AddDays(
				-(
					(
						(int) (from.DayOfWeek )		//[0,6]
						-1				// monday based   //  to [-1,5]
						+7  //make it positive  // [6,12]

					) %7 // make it in [0,6], where 0 means monday.
				) ////[0,-6], to get the start day, which is monday.  

			); // get the start day, which is monday.  
		}

		public static DateTime Monday8ThisWeek(int year,int month,int day)
		{
			return Monday8ThisWeek(new DateTime(year,month,day)); 
		}


		public static DateTime Monday8ThisWeek()
		{
			return Monday8ThisWeek(DateTime.Now.Date);  
		}

		public static DateTime Weekday8ThisWeek(this DateTime from, DayOfWeek dayOfWeek)
		{
			return from.AddDays(
					_week.li_._MondayOffsetX.FroSundayOffset(dayOfWeek)
					-
					_week.li_._MondayOffsetX.FroSundayOffset(from.DayOfWeek)
				)
			;

			return Monday8ThisWeek(from)
				+
				TimeSpan.FromDays(
					_week.li_._MondayOffsetX.FroSundayOffset(dayOfWeek)
				)
			;
		}

		public static DateTime Weekday8ThisWeek( DayOfWeek dayOfWeek)
		{
			return Weekday8ThisWeek(DateTime.Now.Date,dayOfWeek);
		}
	}
}