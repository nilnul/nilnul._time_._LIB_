using nilnul.collection.set;
using System;

namespace nilnul._time.date_
{
	static public class _PresentX
	{
		/// <summary>
		/// in the same year;
		/// </summary>
		/// <param name="month"></param>
		/// <param name="day"></param>
		/// <returns></returns>
		static public DateTime OfMonthDay(int month,int day) {
			return date.of_._PresentX.OfMonthDay(month, day);
			//return new DateTime(DateTime.Now.Year,month,day);
		}

		/// <summary>
		/// intramonth
		/// </summary>
		/// <param name="day"></param>
		/// <returns></returns>
		/// alias:
		///		intramonth
		static public DateTime OfDay(int day) {
			return date.of_._PresentX.OfDay(day);

			//DateTime now = DateTime.Now;
			//return new DateTime(now.Year,now.Month, day);
		}


	}
}
