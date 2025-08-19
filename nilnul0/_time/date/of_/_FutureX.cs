using System;

namespace nilnul._time.date.of_
{
	static public class _FutureX
	{
	
	

		/// <summary>
		/// intramonth
		/// </summary>
		/// <param name="day"></param>
		/// <returns></returns>
		/// alias:
		///		intramonth
		static public DateTime _OfNextMonth_0day(int day) {

			DateTime now = DateTime.Now.AddMonths(1);
		
			return new DateTime	(
				now.Year,
				now.Month		//(now.Month-1 +1 )%12 +1,
				,
				day
			);
		}





	}
}
