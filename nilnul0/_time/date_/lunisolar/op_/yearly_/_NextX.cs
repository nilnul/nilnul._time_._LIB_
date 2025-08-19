using System;
using C = nilnul._time._date.calendar_._ChineseLunisolarX;
using D = (int year, bool leap, int month, int day);


namespace nilnul._time.date_.lunisolar.op_.yearly_
{
	/// <summary>
	/// the date in next year.
	/// 
	/// </summary>
	static public class _NextX
	{
	
		/// <summary>
		/// if 润 month doesnot exits, the non润 month is used;
		/// if day exceeds the month, the last day of that month is used;
		/// </summary>
		/// <param name="lunarDate"></param>
		/// <returns></returns>
		static public (int year, bool leap,int month,  int day) Next(
			(int year,bool leap, int month,  int day) lunarDate
		)
		{
			var cal = nilnul._time._date.calendar_._ChineseLunisolarX.Calendar;

			var next = (year:lunarDate.year +1,leap: lunarDate.leap, lunarDate.month, lunarDate.day);

			/// determines the month
			///
			if (next.leap)
			{

				var leapMonth = C.GetLeapableMonth(next.year);

				if (leapMonth == next.month)
				{
					/// ok
				}
				else 
				{
					next.leap = false;
				}
			}

			/// determines day:
			///

			var days=cal.GetDaysInMonth(next.year, next.month);

			if (next.day>days)
			{
				next.day = days;
			}

			return next;

			

		}
	}
}
