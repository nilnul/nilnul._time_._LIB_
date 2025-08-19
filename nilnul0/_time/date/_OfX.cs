using System;
using System.Runtime.CompilerServices;

namespace nilnul._time.date
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		create
	///		ctor
	///		construct
	static public class _OfX
	{

		/// <summary>
		/// take last day in the month as the basis, and backward by the negative index, where 0 would mean last day, -1 would mean the day before last day.
		/// </summary>
		/// <param name="month"></param>
		/// <param name="day">
		/// eg:
		///		0, -1, ...-30,   for January;
		///	Exception when it's -31 or less, in that:
		///	- for positive days, it's tackled the same way: not moduloed
		///	- not hide mistake when the caller thinks,say -29 is still in range for a February, not means -29%29
		///		-- and the modulo base:30,31,29,28 is not a constant and the caller would should a heavy burden to check that.
		/// ;
		///	
		/// </param>
		/// <returns></returns>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime _OfYmd_2backward(int year, int month,int day) {
			return new DateTime(year,month,
				DateTime.DaysInMonth(year, month) + day		// eg: 31 + -1 =30
			); 
		}

	}
}
