using System;

namespace nilnul._time.date.of_.nary_
{
	[Obsolete(nameof(of_._PresentX) + " is preferred as this is ambiguous between its intention on current context and that it might be understood as on given parameters, which is not nary;")]
	static public class _PresentX
	{
		/// <summary>
		/// in the same year;
		/// </summary>
		/// <param name="month"></param>
		/// <param name="day"></param>
		/// <returns></returns>
		static public DateTime OfMonthDay(int month,int day) {

			return new DateTime(DateTime.Now.Year,month,day);
		}

		/// <summary>
		/// intramonth
		/// </summary>
		/// <param name="day"></param>
		/// <returns></returns>
		/// alias:
		///		intramonth
		static public DateTime OfDay(int day) {

			DateTime now = DateTime.Now;
			return new DateTime(now.Year,now.Month, day);
		}


	}
}
