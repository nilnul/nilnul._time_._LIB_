using System;
using System.Runtime.CompilerServices;

namespace nilnul.time.co
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		距离
	///			，as in 距离上次过了很长时间
	///		duration, <see cref="time.IDuration"/>
	static public class _DistanceX
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
		static public TimeSpan Distance(DateTime a, DateTime b) {
			return  (b-a).Duration();
		}
	}

	public interface IDistance { }

}
