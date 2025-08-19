using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.betwixt_.end_
{
	static public class _LengthX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="end"></param>
		/// <param name="duration">
		/// eg: an absolute number when we make the start some time earlier than the end.
		/// useful if we want to start earlier than the deadline;
		/// </param>
		/// <returns></returns>
		static public DateTime _GetBegin_0end_1duration(this DateTime end, TimeSpan duration) {
			return end - duration;
		}


	}
}
