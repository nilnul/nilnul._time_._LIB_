using System;
using C = nilnul._time._date.calendar_._ChineseLunisolarX;
using D = (int year, bool leap, int month, int day);


namespace nilnul._time.date_.lunisolar.of_
{
	/// <summary>
	/// the date in present scope, the context or environment
	/// 
	/// </summary>
	static public class _PresentX
	{
	
	

		/// <summary>
		/// if 润 month doesnot exits, or if day exceeds the month, xpn is thrown;
		/// </summary>
		/// <param name="lunarDate"></param>
		/// <returns></returns>
		static public DateTime OfMonthDay(
			bool leap, int month,  int day
		)
		{
			return C.ChineseToGregorian(
				(year: _LunisolarX.GetYear(), leap, month, day)
			);
		}
		static public DateTime OfMonthDay(
			 int month,  int day
		)
		{
			return OfMonthDay(false,month,day);
		}



		static public DateTime OfDay(
			  int day
		)
		{
			var monthDay = _LunisolarX.GetYearMonth();

			return C.ChineseToGregorian((year:monthDay.year,leap: monthDay.leap,monthDay. month, day));
		}



	}
}
