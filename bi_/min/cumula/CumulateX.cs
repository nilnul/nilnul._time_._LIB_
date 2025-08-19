using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.bi_.min.cumula
{
	/// <summary>
	/// defaulted for unard
	/// </summary>
	static public class _CumulateX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Min(this IEnumerable<DateTime> times) {
			return times.Aggregate(_CumulatorX.UNARD, bi_._MinX.Min);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Min(params DateTime[] times) {
			return Min((IEnumerable<DateTime>) times);
		}


	}
}
