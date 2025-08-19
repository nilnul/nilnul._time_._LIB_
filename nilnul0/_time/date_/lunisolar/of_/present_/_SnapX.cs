using nilnul._time._date;
using nilnul.order.compare;
using System;
using System.Runtime.CompilerServices;
using C = nilnul._time._date.calendar_._ChineseLunisolarX;
using D = (int year, bool leap, int month, int day);


namespace nilnul._time.date_.lunisolar.of_.present_
{
	/// <summary>
	/// the date in present scope, the context or environment; snap to the nearest
	/// 
	/// </summary>
	static public class _SnapX
	{


		/// <summary>
		/// if 润 month doesnot exits, the non润 month is used;
		/// if day exceeds the month, the last day of that month is used;
		/// </summary>
		/// <param name="lunarDate"></param>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (int year, bool leap,int month,  int day) OfMonthDay(
			bool leap, int month,  int day
		)
		{
			return _LunisolarX.SnapToNearest(year: _LunisolarX.GetYear(), leap: leap, month, day);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (int year, bool leap,int month,  int day) OfMonthDay(
			 int month,  int day
		)
		{
			return OfMonthDay(false,  month, day);

		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (int year, bool leap,int month,  int day) OfMonthDay(
			(bool leap, int month,  int day) lunarMonthDay
		)
		{
			return OfMonthDay( leap: lunarMonthDay.leap, lunarMonthDay.month, lunarMonthDay.day);
		}

		static public DateTime AsGregorian_0monthDay(
			bool leap, int month,  int day
		)
		{
			return _LunisolarX.ToGregorian(
				OfMonthDay(leap,month,day)

			);

		}
		static public DateTime AsGregorian_0monthDay(
			(bool leap, int month,  int day) lunarMonthday
		)
		{
			return AsGregorian_0monthDay(lunarMonthday.leap,lunarMonthday.month,lunarMonthday.day);

		}

		static public (int year, bool leap, int month, int day) OfDay(
			  int day
		)
		{
			var monthDay = _LunisolarX.GetYearMonth();

			return _LunisolarX.SnapToNearest(
				year: monthDay.year, leap: monthDay.leap, monthDay.month, day
			);
		}


	}
}
