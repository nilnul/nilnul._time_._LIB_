using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.of_.month_
{
	/// <summary>
	/// get the last day of a month
	/// </summary>
	static public class _LastDayX
	{
		/// <summary>
		/// last day of current month
		/// </summary>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int Day() {
			return Day(DateTime.Now);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int Day(DateTime now) {
			return DateTime.DaysInMonth(now.Year,now.Month);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime AsDatetime() {
			return AsDatetime(DateTime.Now);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime AsDatetime(DateTime now) {
			return new DateTime(now.Year,now.Month,Day(now));
		}


	}
}
