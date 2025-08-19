using System;
using System.Runtime.CompilerServices;

namespace nilnul.time.co
{
	/// <summary>
	/// <see cref="time.IElapse"/>
	/// </summary>
	static public class _SubtractionX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public TimeSpan Subtract(DateTime a, DateTime b) {
			return a - b;
		}
	}
	public interface ISubtraction:IDifference { }

}
