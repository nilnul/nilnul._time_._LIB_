using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.op_.weeky_
{
	/// <summary>
	/// now or next
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		immediate
	///			,
	/// vs:
	///		<see cref="weeky_._ImminentX"/>,
	///			:Imminent: Refers to something that is about to happen very soon. It conveys a sense of urgency or inevitability but doesn't necessarily mean it is happening right this moment.
	///				,Example: "A storm is imminent," meaning a storm is expected to occur very soon.
	///			:Immediate: Refers to something that is happening right now or without any delay. It implies instant action or occurrence.
	///				,Example: "We need an immediate response," meaning a response is needed right away, without delay.
	///			;In summary, imminent suggests something is on the verge of happening, while immediate means something is happening right now or requires instant action.
	///			
	static public class _ImmediateX
	{
		/// <summary>
		/// the clock part is left untouched;
		/// </summary>
		/// <param name="from"></param>
		/// <param name="dayOfWeek"></param>
		/// <returns></returns>
		public static DateTime ImmediateDiem(this DateTime from, DayOfWeek dayOfWeek)
		{
			return from.Date.AddDays(
				(
					  (int)dayOfWeek- (int)(from.DayOfWeek) +7
				)
				%
				7
			);
		}

		/// <summary>
		/// the time is ignored, and left untouched.
		/// </summary>
		/// <param name="dayOfWeek"></param>
		/// <returns></returns>
		public static DateTime ImmediateDiem( DayOfWeek dayOfWeek)
		{
			return ImmediateDiem(
				DateTime.Now		//.Date
				,dayOfWeek
			);
	
		}
	}
}