using System;
using System.Runtime.CompilerServices;

namespace nilnul._time.date.of_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		current
	static public class _PresentX
	{
		/// <summary>
		/// in the same year;
		/// </summary>
		/// <param name="month"></param>
		/// <param name="day"></param>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime OfMonthDay(int month,int day) {

			return new DateTime(DateTime.Now.Year,month,day);
		}

		/// <summary>
		/// take last day as the basis, and backward by the negative index, where 0 would mean last day, -1 would mean the day before last day.
		/// </summary>
		/// <param name="month"></param>
		/// <param name="day">
		/// eg:
		///		0, -1, ...-30,   for January;
		/// </param>
		/// <returns></returns>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime _OfMonthDay_1backward(int month,int day) {


			return date._OfX._OfYmd_2backward(DateTime.Now.Year, month,day);

			//var days = DateTime.DaysInMonth(DateTime.Now.Year, month);

			//return new DateTime(DateTime.Now.Year, month,
			//	days +day		// eg: 31 + -1 =30
			//); 
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime _OfDay_0backward(int day) {

			DateTime now = DateTime.Now;
			return date._OfX._OfYmd_2backward(
				now.Year,now.Month,day
			);

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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Tomorrow()
		{
			return DateTime.Today.AddDays(1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Overmorrow()
		{
			return DateTime.Today.AddDays(2);
		}





	}
}
