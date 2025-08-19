using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.co
{
	/// <summary>
	/// <see cref="time.grad.IDeviation_bySignedMeasure"/>
	/// </summary>
	/// <see cref="time.IElapse"/>
	/// 

	static public class _DisplaceX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>
		/// the result is not datetime, so this is not a <see cref="nilnul.obj.IBi"/>. But the result can be cast into a time in a context that the time 0 point is presumed.
		/// </returns>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public TimeSpan Displace(DateTime a, DateTime b) {
			return  b-a;
		}
	}

	/// <summary>
	/// alias: elapse
	/// </summary>
	public interface IDisplace :IDifference{

	}
}
