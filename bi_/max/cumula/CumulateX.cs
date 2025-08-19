using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.bi_.max.cumula
{
	/// <summary>
	/// defaulted for unard
	/// </summary>
	static public class _CumulateX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Max(this IEnumerable<DateTime> times) {
			return times.Aggregate(_CumulatorX.UNARD, bi_._MaxX.Max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Max(params DateTime[] times) {
			return Max((IEnumerable<DateTime>) times);
		}


	}
}
