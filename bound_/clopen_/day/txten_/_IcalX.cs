using nilnul._time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.bound_.clopen_.day.txten_
{
	/// <summary>
	/// <see cref="nilnul.time.seq_.ical_._rfc.clauz_._RdateX"/>
	/// </summary>
	static public  class _IcalX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string _Txten_0year_1month_2day( int year, int month, int day) {

			return nilnul._time.date.txten_.num_._YearInFourX._Txten_0year9month9day(year, month, day); 

		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string _Txten(DateTime start) {

			return _Txten_0year_1month_2day(start.Year,start.Month,start.Day);

		}


	}
}
