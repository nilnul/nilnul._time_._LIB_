using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.of_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		context
	///			,same initial as current
	///		current
	///			,but may be ambiguous with <see cref="_PresentX"/> which has to include now.
	///		occasion
	///			, time9venue
	///	vs:
	///		this is not <see cref="of_.nary_"/> (also known as constant), as this is a impure func or method
	///		
	static public class _ContextX
	{
		//[Obsolete()]

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Today() {
			return DateTime.Today; //.Now.Date;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Tomorrow() {
			return DateTime.Today.AddDays(1);//.Date;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Overmorrow() {
			return DateTime.Today.AddDays(2);//.Date;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Yesterday() {
			return DateTime.Today.AddDays(-1);//.Date;
		}

		/// <summary>
		/// In English, "ereyesterday" is a rare, archaic term that was once used but is now almost never seen in modern language.
		/// </summary>
		/// <remarks>
		///In German, it's called vorgestern.
		///In Spanish, anteayer.
		///In French, avant-hier.
		/// </remarks>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public DateTime Anteayer() {
			return DateTime.Today.AddDays(-2);
		}



	}
}
